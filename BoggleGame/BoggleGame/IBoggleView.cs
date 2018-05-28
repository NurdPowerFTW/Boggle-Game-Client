// Created by Wei-Tung and Chen-Chia Wang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleGame
{
    interface IBoggleView
    {
        /// <summary>
        /// Used to set Boggle play board button text
        /// </summary>
        string BoggleBoard { set; }

        /// <summary>
        /// Is the user currently registered?
        /// </summary>
        bool Registered { get; set; }

        /// <summary>
        /// Is the user currently in a game?
        /// </summary>
        bool GameActivated { get; set; }

        /// <summary>
        /// Used to set game status label
        /// </summary>
        /// <param name="text"></param>
        void SetStatusLabel(string text);

        /// <summary>
        /// Used to set player 1 nickname
        /// </summary>
        /// <param name="name"></param>
        void SetPlayer1Name(string name);

        /// <summary>
        /// Used to set player 2 nickname
        /// </summary>
        /// <param name="name"></param>
        void SetPlayer2Name(string name);

        /// <summary>
        /// set the player 1's score
        /// </summary>
        /// <param name="score"></param>
        void SetPlayer1Score(string score);

        /// <summary>
        /// set the player 1's score
        /// </summary>
        /// <param name="score"></param>
        void SetPlayer2Score(string score);

        /// <summary>
        /// set the time
        /// </summary>
        /// <param name="score"></param>
        void SetTimeLeft(string time);

        /// <summary>
        /// restart the game
        /// </summary>
        void Restart();

        /// <summary>
        /// update the board of the answer word list
        /// </summary>
        /// <param name="word"></param>
        /// <param name="points"></param>
        /// <param name="playerIdx"></param>
        void UpdateBoard(string word, int points, int playerIdx);

        /// <summary>
        /// reset the board of the answer word list
        /// </summary>
        void ClearBoard();

        /// <summary>
        /// Fired when user must be registered.
        /// Parameters are name and email.
        /// </summary>
        event Action<string, string> RegisterPressed;

        /// <summary>
        /// Fires when an ongoing action must be canceled.
        /// </summary>
        event Action CancelRegisterPressed;

        /// <summary>
        /// user submitting word
        /// </summary>
        event Action<string> SubmitPressed;

        /// <summary>
        /// event to cencel pending game that is not connect to game
        /// </summary>
        event Action CancelPendingGamePressed;

        /// <summary>
        /// event to join a game
        /// </summary>
        event Action<string> JoinEvent;

        /// <summary>
        /// If state == true, enables all controls that are normally enabled; disables Cancel.
        /// If state == false, disables all controls; enables Cancel.
        /// </summary>
        void EnableControls(bool state);
    }
}
