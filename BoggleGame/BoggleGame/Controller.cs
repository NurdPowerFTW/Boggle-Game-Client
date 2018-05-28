// Created by Wei-Tung and Chen-Chia Wang
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BoggleGame
{
    class Controller
    {
        private IBoggleView view;

        /// <summary>
        /// Used for making http requests to the Boggle server.
        /// </summary>
        private HttpClient client;

        /// <summary>
        /// Used to store user input domain name
        /// </summary>
        private string baseAdress;

        /// <summary>
        /// Current registered user
        /// </summary>
        private User CurrentUser;

        /// <summary>
        /// Used to store game matching info returned from server
        /// </summary>
        private MatchMaking match;

        private bool IsCurrentUserPlayer1;

        private bool BoardHasUpdated;

        /// <summary>
        /// For canceling the current operation
        /// </summary>
        private CancellationTokenSource tokenSource;

        /// <summary>
        /// Construtor, initilize events
        /// </summary>
        /// <param name="view"></param>
        public Controller(IBoggleView view)
        {
            this.view = view;
            baseAdress = "";
            CurrentUser = new User();
            match = new MatchMaking();
            BoardHasUpdated = false;
            view.RegisterPressed += RegisterUser;
            view.CancelRegisterPressed += Cancel;
            view.JoinEvent += JoinGame;
            view.CancelPendingGamePressed += Cancel;
            view.SubmitPressed += SubmitWord;
        }

        /// <summary>
        /// cancel event
        /// </summary>
        private void Cancel()
        {
            if (tokenSource != null)
            {
                tokenSource.Cancel();
            }
        }

        /// <summary>
        /// Registers a user with the given name.
        /// </summary>
        private async void RegisterUser(string nickname, string url)
        {
            // If there is an exisiting client, kill it
            if (client != null)
                client.Dispose();

            try
            {
                client = CreateClient(url);
            }
            catch (Exception)
            {
                view.SetStatusLabel("Error finding URL.");
                
                return;
            }

            baseAdress = url;

            try
            {
                view.EnableControls(false);

                // Create the parameter
                dynamic user = new ExpandoObject();
                user.Nickname = nickname;

                // Compose and send the request.
                tokenSource = new CancellationTokenSource();
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("users", content, tokenSource.Token);

                // Deal with the response
                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    CurrentUser.Nickname = nickname;
                    CurrentUser.UserToken = JsonConvert.DeserializeObject<User>(result).UserToken;
                    view.Registered = true;
                    view.SetStatusLabel("Register Succesful!");

                }
                else if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    view.SetStatusLabel("The nickname you have provided is either empty or contains more than 50 characters. Please try a different nickaname");
                }
                else
                {
                    view.SetStatusLabel("Error registering: " + response.StatusCode + "\n" + response.ReasonPhrase);
                    
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                view.EnableControls(true);
            }
        }


        /// <summary>
        /// Join a game by calling join game API
        /// </summary>
        /// <param name="timeLimit"></param>
        private async void JoinGame(string timeLimit)
        {
            // Create the parameter
            dynamic games = new ExpandoObject();
            games.UserToken = CurrentUser.UserToken;

            if (!Double.TryParse(timeLimit, out double limit))
            {
                view.SetStatusLabel("Invalid time format");
                return;
            }
            games.TimeLimit = limit;
            HttpResponseMessage response;
            try
            {
                view.EnableControls(false);
                // Compose and send the request.
                tokenSource = new CancellationTokenSource();
                StringContent content = new StringContent(JsonConvert.SerializeObject(games), Encoding.UTF8, "application/json");
                response = await client.PostAsync("games", content, tokenSource.Token);

                HttpResponseMessage queueReponse;
                Status queueStatus = new Status();

                // Deal with the response
                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    match.GameID = JsonConvert.DeserializeObject<MatchMaking>(result).GameID;

                    if (response.StatusCode == HttpStatusCode.Accepted)
                    {
                        IsCurrentUserPlayer1 = true;
                    }
                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        view.GameActivated = true;
                        IsCurrentUserPlayer1 = false;
                        view.SetStatusLabel("Let the game begins! ");
                       
                    }
                    else if (response.StatusCode == HttpStatusCode.Accepted)
                    {
                        view.SetStatusLabel("Awaiting opponent...");

                        // if join a pending game, keep looping until finds an opponenet
                        while (true)
                        {
                            queueStatus = new Status();
                            queueReponse = await client.GetAsync("games/" + match.GameID, tokenSource.Token);
                            queueStatus = JsonConvert.DeserializeObject<Status>(queueReponse.Content.ReadAsStringAsync().Result);

                            if (queueStatus.GameState == "active")
                            {
                                view.SetStatusLabel("Match found!");
                                
                                view.GameActivated = true;
                                view.BoggleBoard = queueStatus.Board;
                                break;
                            }
                            //view.SetStatusLabel("Searching for a game...");
                            // Prevent excessive server call
                            await Task.Delay(1000);
                        }
                    }

                    // if a game starts, start update game status
                    UpdateGame();
                }
                else if (response.StatusCode == HttpStatusCode.Conflict)
                {
                    //view.GameActivated = false;
                    MessageBox.Show("Current registered player is already in a pending game");
                }
                else if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    view.GameActivated = false;
                    MessageBox.Show("Time limit must be an integer between 5 and 120 (inclusive).");
                }
                else
                {
                    view.GameActivated = false;
                    MessageBox.Show("Problem occurred during match making. Reason: " + response.StatusCode);
                }


            }
            catch (TaskCanceledException)
            {
                view.GameActivated = false;
                games = new ExpandoObject();
                games.UserToken = CurrentUser.UserToken;
                response = await client.PutAsync("games", new StringContent(JsonConvert.SerializeObject(games), Encoding.UTF8, "application/json"));
                BoardHasUpdated = false;
            }
            finally
            {
                view.EnableControls(true);
            }
        }

        /// <summary>
        /// Update game status
        /// </summary>
        private async void UpdateGame()
        {
            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;

            tokenSource = new CancellationTokenSource();
            dynamic games = new ExpandoObject();
            games.UserToken = CurrentUser.UserToken;
            HttpResponseMessage cancelResponse;
            view.EnableControls(false);
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                Status gameStatus = new Status();

                // while game is still activated, keep updating 
                while (view.GameActivated)
                {
                    // condition check for Brief=yes paramter
                    if (!BoardHasUpdated)
                    {
                        response = await client.GetAsync("games/" + match.GameID, tokenSource.Token);
                        gameStatus = JsonConvert.DeserializeObject<Status>(response.Content.ReadAsStringAsync().Result);

                    }
                    else
                    {
                        response = await client.GetAsync("games/" + match.GameID + "?Brief=yes", tokenSource.Token);
                        gameStatus = JsonConvert.DeserializeObject<Status>(response.Content.ReadAsStringAsync().Result);
                    }

                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        MessageBox.Show("GameID is invaid");
                        view.GameActivated = false;

                    }
                    else if (gameStatus.GameState == "active")
                    {
                        // if enter update the first time
                        if (!BoardHasUpdated)
                        {
                            
                            view.GameActivated = true;
                            view.BoggleBoard = gameStatus.Board;
                            view.SetPlayer1Name(gameStatus.Player1.Nickname);
                            view.SetPlayer2Name(gameStatus.Player2.Nickname);
                            BoardHasUpdated = true;
                        }
                        view.SetPlayer1Score(gameStatus.Player1.Score);
                        view.SetPlayer2Score(gameStatus.Player2.Score);
                        view.SetTimeLeft(gameStatus.TimeLeft);
                    }
                    else if (gameStatus.GameState == "completed")
                    {
                        MessageBox.Show("Game ended");
                        view.GameActivated = false;
                        view.SetStatusLabel("Game ended");
                        view.EnableControls(true);
                    }
                    await Task.Delay(1000);
                }
                response = client.GetAsync("games/" + match.GameID, tokenSource.Token).Result;

                if (response.IsSuccessStatusCode)
                {

                    // post final result
                    string temp = response.Content.ReadAsStringAsync().Result;
                    gameStatus = JsonConvert.DeserializeObject<Status>(temp);
                    view.SetTimeLeft(gameStatus.TimeLeft);
                    view.SetPlayer1Score(gameStatus.Player1.Score);
                    view.SetPlayer2Score(gameStatus.Player2.Score);

                    foreach (Status.WordsPlayed wordPlayed in IsCurrentUserPlayer1 ? gameStatus.Player2.history : gameStatus.Player1.history)
                        view.UpdateBoard(wordPlayed.Word, wordPlayed.Score, IsCurrentUserPlayer1 ? 2 : 1);
                }
                
            }
            catch (TaskCanceledException)
            {
                view.GameActivated = false;
                games = new ExpandoObject();
                games.UserToken = CurrentUser.UserToken;
                cancelResponse = await client.PutAsync("games", new StringContent(JsonConvert.SerializeObject(games), Encoding.UTF8, "application/json"));
                view.SetStatusLabel("Game cancelled");
                view.SetTimeLeft("");
                view.Restart();
                BoardHasUpdated = false;
            }
            finally
            {
                view.SetTimeLeft("");
                view.Restart();
                view.EnableControls(true);
            }
        }

        /// <summary>
        /// Submit the word choice
        /// </summary>
        /// <param name="playedWord"></param>
        private async void SubmitWord(string playedWord)
        {
            string temp1 = playedWord.ToLower();
            string temp2 = temp1.ToLower();
            dynamic games = new ExpandoObject();
            games.UserToken = CurrentUser.UserToken;
            games.Word = temp2;
            StringContent contents = new StringContent(JsonConvert.SerializeObject(games), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("games/" + match.GameID, contents, tokenSource.Token);

            if (response.IsSuccessStatusCode)
            {
                dynamic result = JsonConvert.DeserializeObject<Status.WordsPlayed>(response.Content.ReadAsStringAsync().Result);
                view.UpdateBoard(playedWord.Trim(), result.Score, IsCurrentUserPlayer1 ? 1 : 2);
            }
            else if (response.StatusCode == HttpStatusCode.Forbidden)
                view.SetStatusLabel("Word is null or empty when trimmed, GameID or UserToken is missing or invalid, or UserToken is not a player in the game identified by GameID");
            else
                view.SetStatusLabel("Error occurs when processing the request: "+ response.StatusCode);
        }

        /// <summary>
        /// Creates an HttpClient for communicating with the server.
        /// </summary>
        private static HttpClient CreateClient(string url)
        {
            // Create a client whose base address is the GitHub server
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Tell the server that the client will accept this particular type of response data
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            // There is more client configuration to do, depending on the request.
            return client;
        }

        /// <summary>
        /// The User class represents a response to a post request to "users" (for registering
        /// a user).
        /// </summary>
        class User
        {
            public string Nickname { get; set; }
            public string UserToken { get; set; }
        }

        /// <summary>
        /// stores game id
        /// </summary>
        class MatchMaking
        {
            public string GameID { get; set; }
        }

        /// <summary>
        /// store the current game status
        /// </summary>
        class Status
        {
            public string GameState { get; set; }
            public string Board { get; set; }
            public string TimeLimit { get; set; }
            public string TimeLeft { get; set; }

            public Player Player1 { get; set; }
            public Player Player2 { get; set; }

            public class Player
            {
                public string Nickname { get; set; }
                public string Score { get; set; }
                public List<WordsPlayed> history = new List<WordsPlayed>();
            }
            public class WordsPlayed
            {
                public string Word { get; set; }
                public int Score { get; set; }
            }

        }
    }
}
