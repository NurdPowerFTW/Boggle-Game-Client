namespace BoggleGame
{
    partial class BoggleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterButton = new System.Windows.Forms.Button();
            this.TimeLimitBox = new System.Windows.Forms.TextBox();
            this.Nickname = new System.Windows.Forms.Label();
            this.NicknameBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PlayedWord = new System.Windows.Forms.Label();
            this.PlayedWordBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.ButtonManager = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonTen = new System.Windows.Forms.Button();
            this.ButtonEleven = new System.Windows.Forms.Button();
            this.ButtonTwelve = new System.Windows.Forms.Button();
            this.ButtonThirteen = new System.Windows.Forms.Button();
            this.ButtonFourteen = new System.Windows.Forms.Button();
            this.ButtonFifteen = new System.Windows.Forms.Button();
            this.ScoreLabel1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.p2_ans = new System.Windows.Forms.Label();
            this.p1_ans = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonManager.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.Location = new System.Drawing.Point(333, 245);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(150, 60);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // TimeLimitBox
            // 
            this.TimeLimitBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLimitBox.Location = new System.Drawing.Point(371, 208);
            this.TimeLimitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeLimitBox.Name = "TimeLimitBox";
            this.TimeLimitBox.Size = new System.Drawing.Size(288, 25);
            this.TimeLimitBox.TabIndex = 12;
            // 
            // Nickname
            // 
            this.Nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Nickname.AutoSize = true;
            this.Nickname.Location = new System.Drawing.Point(288, 135);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(64, 15);
            this.Nickname.TabIndex = 14;
            this.Nickname.Text = "Nickname";
            // 
            // NicknameBox
            // 
            this.NicknameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NicknameBox.Location = new System.Drawing.Point(371, 132);
            this.NicknameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NicknameBox.Name = "NicknameBox";
            this.NicknameBox.Size = new System.Drawing.Size(288, 25);
            this.NicknameBox.TabIndex = 15;
            this.NicknameBox.TextChanged += new System.EventHandler(this.Registration_TextChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(288, 211);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 15);
            this.TimeLabel.TabIndex = 33;
            this.TimeLabel.Text = "Time";
            // 
            // PlayedWord
            // 
            this.PlayedWord.AutoSize = true;
            this.PlayedWord.Location = new System.Drawing.Point(280, 828);
            this.PlayedWord.Name = "PlayedWord";
            this.PlayedWord.Size = new System.Drawing.Size(39, 15);
            this.PlayedWord.TabIndex = 50;
            this.PlayedWord.Text = "Word";
            // 
            // PlayedWordBox
            // 
            this.PlayedWordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayedWordBox.Location = new System.Drawing.Point(363, 825);
            this.PlayedWordBox.Name = "PlayedWordBox";
            this.PlayedWordBox.Size = new System.Drawing.Size(282, 25);
            this.PlayedWordBox.TabIndex = 51;
            this.PlayedWordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayedWordBox_KeyDown);
            // 
            // ServerLabel
            // 
            this.ServerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(288, 172);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(44, 15);
            this.ServerLabel.TabIndex = 31;
            this.ServerLabel.Text = "Server";
            // 
            // ServerBox
            // 
            this.ServerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerBox.Location = new System.Drawing.Point(371, 169);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(288, 25);
            this.ServerBox.TabIndex = 32;
            this.ServerBox.TextChanged += new System.EventHandler(this.Registration_TextChanged);
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.JoinGameButton.Location = new System.Drawing.Point(333, 310);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(150, 60);
            this.JoinGameButton.TabIndex = 52;
            this.JoinGameButton.Text = "Join Game";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            this.JoinGameButton.Click += new System.EventHandler(this.JoinGameButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(489, 245);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 60);
            this.CancelButton.TabIndex = 53;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ExitGameButton.Location = new System.Drawing.Point(489, 310);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(150, 60);
            this.ExitGameButton.TabIndex = 54;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // ButtonManager
            // 
            this.ButtonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonManager.Controls.Add(this.ButtonZero);
            this.ButtonManager.Controls.Add(this.ButtonOne);
            this.ButtonManager.Controls.Add(this.ButtonTwo);
            this.ButtonManager.Controls.Add(this.ButtonThree);
            this.ButtonManager.Controls.Add(this.ButtonFour);
            this.ButtonManager.Controls.Add(this.ButtonFive);
            this.ButtonManager.Controls.Add(this.ButtonSix);
            this.ButtonManager.Controls.Add(this.ButtonSeven);
            this.ButtonManager.Controls.Add(this.ButtonEight);
            this.ButtonManager.Controls.Add(this.ButtonNine);
            this.ButtonManager.Controls.Add(this.ButtonTen);
            this.ButtonManager.Controls.Add(this.ButtonEleven);
            this.ButtonManager.Controls.Add(this.ButtonTwelve);
            this.ButtonManager.Controls.Add(this.ButtonThirteen);
            this.ButtonManager.Controls.Add(this.ButtonFourteen);
            this.ButtonManager.Controls.Add(this.ButtonFifteen);
            this.ButtonManager.Location = new System.Drawing.Point(274, 376);
            this.ButtonManager.Name = "ButtonManager";
            this.ButtonManager.Size = new System.Drawing.Size(425, 425);
            this.ButtonManager.TabIndex = 59;
            // 
            // ButtonZero
            // 
            this.ButtonZero.Location = new System.Drawing.Point(3, 3);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(100, 100);
            this.ButtonZero.TabIndex = 0;
            this.ButtonZero.UseVisualStyleBackColor = true;
            // 
            // ButtonOne
            // 
            this.ButtonOne.Location = new System.Drawing.Point(109, 3);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(100, 100);
            this.ButtonOne.TabIndex = 1;
            this.ButtonOne.UseVisualStyleBackColor = true;
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Location = new System.Drawing.Point(215, 3);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(100, 100);
            this.ButtonTwo.TabIndex = 2;
            this.ButtonTwo.UseVisualStyleBackColor = true;
            // 
            // ButtonThree
            // 
            this.ButtonThree.Location = new System.Drawing.Point(321, 3);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(100, 100);
            this.ButtonThree.TabIndex = 3;
            this.ButtonThree.UseVisualStyleBackColor = true;
            // 
            // ButtonFour
            // 
            this.ButtonFour.Location = new System.Drawing.Point(3, 109);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(100, 100);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.UseVisualStyleBackColor = true;
            // 
            // ButtonFive
            // 
            this.ButtonFive.Location = new System.Drawing.Point(109, 109);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(100, 100);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.UseVisualStyleBackColor = true;
            // 
            // ButtonSix
            // 
            this.ButtonSix.Location = new System.Drawing.Point(215, 109);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(100, 100);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.UseVisualStyleBackColor = true;
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Location = new System.Drawing.Point(321, 109);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(100, 100);
            this.ButtonSeven.TabIndex = 7;
            this.ButtonSeven.UseVisualStyleBackColor = true;
            // 
            // ButtonEight
            // 
            this.ButtonEight.Location = new System.Drawing.Point(3, 215);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(100, 100);
            this.ButtonEight.TabIndex = 8;
            this.ButtonEight.UseVisualStyleBackColor = true;
            // 
            // ButtonNine
            // 
            this.ButtonNine.Location = new System.Drawing.Point(109, 215);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(100, 100);
            this.ButtonNine.TabIndex = 9;
            this.ButtonNine.UseVisualStyleBackColor = true;
            // 
            // ButtonTen
            // 
            this.ButtonTen.Location = new System.Drawing.Point(215, 215);
            this.ButtonTen.Name = "ButtonTen";
            this.ButtonTen.Size = new System.Drawing.Size(100, 100);
            this.ButtonTen.TabIndex = 10;
            this.ButtonTen.UseVisualStyleBackColor = true;
            // 
            // ButtonEleven
            // 
            this.ButtonEleven.Location = new System.Drawing.Point(321, 215);
            this.ButtonEleven.Name = "ButtonEleven";
            this.ButtonEleven.Size = new System.Drawing.Size(100, 100);
            this.ButtonEleven.TabIndex = 11;
            this.ButtonEleven.UseVisualStyleBackColor = true;
            // 
            // ButtonTwelve
            // 
            this.ButtonTwelve.Location = new System.Drawing.Point(3, 321);
            this.ButtonTwelve.Name = "ButtonTwelve";
            this.ButtonTwelve.Size = new System.Drawing.Size(100, 100);
            this.ButtonTwelve.TabIndex = 12;
            this.ButtonTwelve.UseVisualStyleBackColor = true;
            // 
            // ButtonThirteen
            // 
            this.ButtonThirteen.Location = new System.Drawing.Point(109, 321);
            this.ButtonThirteen.Name = "ButtonThirteen";
            this.ButtonThirteen.Size = new System.Drawing.Size(100, 100);
            this.ButtonThirteen.TabIndex = 13;
            this.ButtonThirteen.UseVisualStyleBackColor = true;
            // 
            // ButtonFourteen
            // 
            this.ButtonFourteen.Location = new System.Drawing.Point(215, 321);
            this.ButtonFourteen.Name = "ButtonFourteen";
            this.ButtonFourteen.Size = new System.Drawing.Size(100, 100);
            this.ButtonFourteen.TabIndex = 14;
            this.ButtonFourteen.UseVisualStyleBackColor = true;
            // 
            // ButtonFifteen
            // 
            this.ButtonFifteen.Location = new System.Drawing.Point(321, 321);
            this.ButtonFifteen.Name = "ButtonFifteen";
            this.ButtonFifteen.Size = new System.Drawing.Size(100, 100);
            this.ButtonFifteen.TabIndex = 15;
            this.ButtonFifteen.UseVisualStyleBackColor = true;
            // 
            // ScoreLabel1
            // 
            this.ScoreLabel1.AutoSize = true;
            this.ScoreLabel1.Location = new System.Drawing.Point(43, 82);
            this.ScoreLabel1.Name = "ScoreLabel1";
            this.ScoreLabel1.Size = new System.Drawing.Size(43, 15);
            this.ScoreLabel1.TabIndex = 60;
            this.ScoreLabel1.Text = "Score:";
            this.ScoreLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(410, 57);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(165, 15);
            this.StatusLabel.TabIndex = 61;
            this.StatusLabel.Text = " Welcome to Boggle Game!";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.Location = new System.Drawing.Point(881, 57);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(50, 15);
            this.Player2NameLabel.TabIndex = 63;
            this.Player2NameLabel.Text = "Player2";
            this.Player2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.Location = new System.Drawing.Point(884, 82);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(47, 15);
            this.ScoreLabel2.TabIndex = 64;
            this.ScoreLabel2.Text = "Score: ";
            this.ScoreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.Location = new System.Drawing.Point(43, 57);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(50, 15);
            this.Player1NameLabel.TabIndex = 65;
            this.Player1NameLabel.Text = "Player1";
            this.Player1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Location = new System.Drawing.Point(466, 94);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeLeftLabel.TabIndex = 66;
            this.TimeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_ans
            // 
            this.p2_ans.AutoSize = true;
            this.p2_ans.Location = new System.Drawing.Point(884, 134);
            this.p2_ans.Name = "p2_ans";
            this.p2_ans.Size = new System.Drawing.Size(0, 15);
            this.p2_ans.TabIndex = 67;
            // 
            // p1_ans
            // 
            this.p1_ans.AutoEllipsis = true;
            this.p1_ans.AutoSize = true;
            this.p1_ans.Location = new System.Drawing.Point(45, 132);
            this.p1_ans.Name = "p1_ans";
            this.p1_ans.Size = new System.Drawing.Size(0, 15);
            this.p1_ans.TabIndex = 68;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.instructionToolStripMenuItem.Text = "Instruction";
            this.instructionToolStripMenuItem.Click += new System.EventHandler(this.instructionToolStripMenuItem_Click);
            // 
            // BoggleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 873);
            this.Controls.Add(this.p1_ans);
            this.Controls.Add(this.p2_ans);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Player1NameLabel);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.Player2NameLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ScoreLabel1);
            this.Controls.Add(this.ButtonManager);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.PlayedWordBox);
            this.Controls.Add(this.PlayedWord);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.NicknameBox);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.TimeLimitBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BoggleWindow";
            this.Text = "BoggleGame";
            this.Load += new System.EventHandler(this.BoggleWindow_Load);
            this.ButtonManager.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox TimeLimitBox;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.TextBox NicknameBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PlayedWord;
        private System.Windows.Forms.TextBox PlayedWordBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.Button JoinGameButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.FlowLayoutPanel ButtonManager;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonTen;
        private System.Windows.Forms.Button ButtonEleven;
        private System.Windows.Forms.Button ButtonTwelve;
        private System.Windows.Forms.Button ButtonThirteen;
        private System.Windows.Forms.Button ButtonFourteen;
        private System.Windows.Forms.Button ButtonFifteen;
        private System.Windows.Forms.Label ScoreLabel1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label Player2NameLabel;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.Label Player1NameLabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Label p2_ans;
        private System.Windows.Forms.Label p1_ans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
    }
}

