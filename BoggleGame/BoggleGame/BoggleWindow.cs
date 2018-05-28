// Created by Wei-Tung and Chen-Chia Wang
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoggleGame
{
    /// <summary>
    /// A GUI window representation of the game
    /// </summary>
    public partial class BoggleWindow : Form, IBoggleView
    {

        public event Action<string, string> RegisterPressed;
        /// <summary>
        /// Fires when an ongoing action must be canceled.
        /// </summary>
        public event Action CancelRegisterPressed;
        public event Action CancelPendingGamePressed;
        public event Action<string> JoinEvent;
        public event Action<string> SubmitPressed;
        private string AnswerStr = "";

        delegate void StringArgReturningVoidDelegate(string text);
        public bool Registered { get; set; }

        public bool GameActivated { get; set; }


        public void SetStatusLabel(string text)
        {

            if (StatusLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetStatusLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                StatusLabel.Text = text;
            }

        }

        public void SetPlayer1Name(string name)
        {
            if (Player1NameLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetPlayer1Name);
                this.Invoke(d, new object[] { name });
            }
            else
            {
                Player1NameLabel.Text = name;
            }
        }

        public void SetPlayer2Name(string name)
        {
            if (Player2NameLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetPlayer2Name);
                this.Invoke(d, new object[] { name });
            }
            else
            {
                Player2NameLabel.Text = name;
            }
        }

        public void SetPlayer1Score(string score)
        {
            if (ScoreLabel1.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetPlayer1Score);
                this.Invoke(d, new object[] { score });
            }
            else
            {
                ScoreLabel1.Text = score;
            }
        }

        public void SetPlayer2Score(string score)
        {
            if (ScoreLabel2.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetPlayer2Score);
                this.Invoke(d, new object[] { score });
            }
            else
            {
                ScoreLabel2.Text = score;
            }
        }
        
        public void SetTimeLeft(string time)
        {
            if (TimeLeftLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTimeLeft);
                this.Invoke(d, new object[] { time });
            }
            else
            {
                TimeLeftLabel.Text = time;
            }
        }

        public void UpdateBoard(string word, int points, int player)
        {
            if (player == 1)
            {
                ScoreLabel1.Text = points.ToString();
                p1_ans.Text += (word.ToString().ToLower() + "\n");

            }

            if (player == 2)
            {
                ScoreLabel2.Text = points.ToString();
                p2_ans.Text += (word.ToString().ToLower() + "\n");
            }
        }

        public void Restart()
        {
            p1_ans.Text = "";
            p2_ans.Text = "";

        }


        public BoggleWindow()
        {
            InitializeComponent();
            StatusLabel.Text = "Welcome to Boggle Game!";
            CancelButton.Enabled = false;
            JoinGameButton.Enabled = false;
            ExitGameButton.Enabled = false;
            ButtonManager.Enabled = false;
            PlayedWordBox.Enabled = false;
            // Initialize every button binded to buttonManager
            // When button is pressed, fire the event (Button_Click)
            foreach (Button button in ButtonManager.Controls.OfType<Button>())
            {
                button.Click += Button_Click;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;

            AnswerStr += temp.Text;
            PlayedWordBox.Text = AnswerStr.ToLower();
        }

        public string BoggleBoard
        {
            set
            {
                string words = value;
                int i = 0;
                foreach (Button control in ButtonManager.Controls.OfType<Button>())
                {
                    control.Text = words[i] + "";
                    i++;
                }
            }
        }


        public void ClearBoard()
        {
            Player1NameLabel.Text = "Player1";
            p1_ans.Text = "";
            Player2NameLabel.Text = "Player2";
            p2_ans.Text = "";
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterPressed?.Invoke(NicknameBox.Text.Trim(), ServerBox.Text);

        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {

            JoinEvent(TimeLimitBox.Text.Trim());

        }


        /// <summary>
        /// If state == true, enables all controls that are normally enabled; disables Cancel.
        /// If state == false, disables all controls; enables Cancel.
        /// </summary>
        public void EnableControls(bool state)
        {

            RegisterButton.Enabled = !Registered && state && NicknameBox.Text.Length > 0 && ServerBox.Text.Length > 0;

            TimeLimitBox.Enabled = state && Registered;
            JoinGameButton.Enabled = state && Registered && !GameActivated;
            ExitGameButton.Enabled = !state || GameActivated ;
            ButtonManager.Enabled = !state || GameActivated;
            CancelButton.Enabled =  !state && GameActivated;
            PlayedWordBox.Enabled = GameActivated;
        }

        private void Registration_TextChanged(object sender, EventArgs e)
        {
             
            EnableControls(true);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelRegisterPressed?.Invoke();
            MessageBox.Show("Registration cancelled");
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            CancelPendingGamePressed?.Invoke();
        }

        private void PlayedWordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string temp = AnswerStr;
                PlayedWordBox.Text = "";
                AnswerStr = "";
                SubmitPressed(temp);
                
            }
        }

        private void BoggleWindow_Load(object sender, EventArgs e)
        {

        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Boggle game window. Please register before playing. To register, to supply a domain name url " +
                "(http://ice.eng.utah.edu/BoggleService.svc/ is our default url). To play, please press join game. You can cancel" +
                "any ongoing or pending game at any time and rejoin the game afterwards. Please supply time limit between 5 to 120 seconds" +
                " Please use the 4X4 grid buttons to come up " +
                "with words and simply hit ENTER inside of the textbox next to Word on the bottom of the window. Have fun :)");
        }
    }
}
