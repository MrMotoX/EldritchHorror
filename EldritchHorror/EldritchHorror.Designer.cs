namespace EldritchHorror
{
    partial class MainForm
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
            this.ButtonNewGame = new System.Windows.Forms.Button();
            this.ListSelection = new System.Windows.Forms.ListBox();
            this.ButtonNewPlayer = new System.Windows.Forms.Button();
            this.ButtonAcceptSelection = new System.Windows.Forms.Button();
            this.ButtonAbortSelection = new System.Windows.Forms.Button();
            this.GroupBoxPlayer1 = new System.Windows.Forms.GroupBox();
            this.TextBoxInvestigator = new System.Windows.Forms.TextBox();
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.ButtonChooseInvestigator = new System.Windows.Forms.Button();
            this.ButtonAcceptPlayer = new System.Windows.Forms.Button();
            this.ButtonAbortPlayer = new System.Windows.Forms.Button();
            this.GroupBoxPlayer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNewGame
            // 
            this.ButtonNewGame.Location = new System.Drawing.Point(12, 12);
            this.ButtonNewGame.Name = "ButtonNewGame";
            this.ButtonNewGame.Size = new System.Drawing.Size(99, 30);
            this.ButtonNewGame.TabIndex = 0;
            this.ButtonNewGame.Text = "Nytt spel";
            this.ButtonNewGame.UseVisualStyleBackColor = true;
            this.ButtonNewGame.Click += new System.EventHandler(this.ButtonNewGame_Click);
            // 
            // ListSelection
            // 
            this.ListSelection.DisplayMember = "Name";
            this.ListSelection.FormattingEnabled = true;
            this.ListSelection.Location = new System.Drawing.Point(718, 12);
            this.ListSelection.Name = "ListSelection";
            this.ListSelection.Size = new System.Drawing.Size(193, 251);
            this.ListSelection.TabIndex = 1;
            this.ListSelection.Visible = false;
            // 
            // ButtonNewPlayer
            // 
            this.ButtonNewPlayer.Location = new System.Drawing.Point(117, 12);
            this.ButtonNewPlayer.Name = "ButtonNewPlayer";
            this.ButtonNewPlayer.Size = new System.Drawing.Size(99, 30);
            this.ButtonNewPlayer.TabIndex = 2;
            this.ButtonNewPlayer.Text = "Ny spelare";
            this.ButtonNewPlayer.UseVisualStyleBackColor = true;
            this.ButtonNewPlayer.Click += new System.EventHandler(this.ButtonNewPlayer_Click);
            // 
            // ButtonAcceptSelection
            // 
            this.ButtonAcceptSelection.Location = new System.Drawing.Point(718, 269);
            this.ButtonAcceptSelection.Name = "ButtonAcceptSelection";
            this.ButtonAcceptSelection.Size = new System.Drawing.Size(94, 30);
            this.ButtonAcceptSelection.TabIndex = 3;
            this.ButtonAcceptSelection.Text = "Acceptera";
            this.ButtonAcceptSelection.UseVisualStyleBackColor = true;
            this.ButtonAcceptSelection.Visible = false;
            this.ButtonAcceptSelection.Click += new System.EventHandler(this.ButtonAcceptSelection_Click);
            // 
            // ButtonAbortSelection
            // 
            this.ButtonAbortSelection.Location = new System.Drawing.Point(818, 269);
            this.ButtonAbortSelection.Name = "ButtonAbortSelection";
            this.ButtonAbortSelection.Size = new System.Drawing.Size(93, 30);
            this.ButtonAbortSelection.TabIndex = 3;
            this.ButtonAbortSelection.Text = "Avbryt";
            this.ButtonAbortSelection.UseVisualStyleBackColor = true;
            this.ButtonAbortSelection.Visible = false;
            this.ButtonAbortSelection.Click += new System.EventHandler(this.ButtonAbortSelection_Click);
            // 
            // GroupBoxPlayer1
            // 
            this.GroupBoxPlayer1.Controls.Add(this.ButtonChooseInvestigator);
            this.GroupBoxPlayer1.Controls.Add(this.TextBoxInvestigator);
            this.GroupBoxPlayer1.Location = new System.Drawing.Point(12, 179);
            this.GroupBoxPlayer1.Name = "GroupBoxPlayer1";
            this.GroupBoxPlayer1.Size = new System.Drawing.Size(204, 69);
            this.GroupBoxPlayer1.TabIndex = 4;
            this.GroupBoxPlayer1.TabStop = false;
            this.GroupBoxPlayer1.Text = "Spelare 1";
            this.GroupBoxPlayer1.Visible = false;
            // 
            // TextBoxInvestigator
            // 
            this.TextBoxInvestigator.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxInvestigator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInvestigator.Location = new System.Drawing.Point(7, 20);
            this.TextBoxInvestigator.Name = "TextBoxInvestigator";
            this.TextBoxInvestigator.Size = new System.Drawing.Size(159, 13);
            this.TextBoxInvestigator.TabIndex = 0;
            this.TextBoxInvestigator.Text = "Ingen detektiv vald";
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Location = new System.Drawing.Point(12, 48);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(204, 20);
            this.TextBoxPlayerName.TabIndex = 5;
            this.TextBoxPlayerName.Visible = false;
            this.TextBoxPlayerName.WordWrap = false;
            // 
            // ButtonChooseInvestigator
            // 
            this.ButtonChooseInvestigator.Location = new System.Drawing.Point(6, 39);
            this.ButtonChooseInvestigator.Name = "ButtonChooseInvestigator";
            this.ButtonChooseInvestigator.Size = new System.Drawing.Size(192, 23);
            this.ButtonChooseInvestigator.TabIndex = 1;
            this.ButtonChooseInvestigator.Text = "Välj detektiv";
            this.ButtonChooseInvestigator.UseVisualStyleBackColor = true;
            this.ButtonChooseInvestigator.Click += new System.EventHandler(this.ButtonChooseInvestigator_Click);
            // 
            // ButtonAcceptPlayer
            // 
            this.ButtonAcceptPlayer.Location = new System.Drawing.Point(12, 75);
            this.ButtonAcceptPlayer.Name = "ButtonAcceptPlayer";
            this.ButtonAcceptPlayer.Size = new System.Drawing.Size(99, 23);
            this.ButtonAcceptPlayer.TabIndex = 6;
            this.ButtonAcceptPlayer.Text = "Ok";
            this.ButtonAcceptPlayer.UseVisualStyleBackColor = true;
            this.ButtonAcceptPlayer.Visible = false;
            this.ButtonAcceptPlayer.Click += new System.EventHandler(this.ButtonAcceptPlayer_Click);
            // 
            // ButtonAbortPlayer
            // 
            this.ButtonAbortPlayer.Location = new System.Drawing.Point(117, 75);
            this.ButtonAbortPlayer.Name = "ButtonAbortPlayer";
            this.ButtonAbortPlayer.Size = new System.Drawing.Size(99, 23);
            this.ButtonAbortPlayer.TabIndex = 6;
            this.ButtonAbortPlayer.Text = "Avbryt";
            this.ButtonAbortPlayer.UseVisualStyleBackColor = true;
            this.ButtonAbortPlayer.Visible = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(923, 546);
            this.Controls.Add(this.ButtonAbortPlayer);
            this.Controls.Add(this.ButtonAcceptPlayer);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Controls.Add(this.GroupBoxPlayer1);
            this.Controls.Add(this.ButtonAbortSelection);
            this.Controls.Add(this.ButtonAcceptSelection);
            this.Controls.Add(this.ButtonNewPlayer);
            this.Controls.Add(this.ListSelection);
            this.Controls.Add(this.ButtonNewGame);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.GroupBoxPlayer1.ResumeLayout(false);
            this.GroupBoxPlayer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewGame;
        private System.Windows.Forms.ListBox ListSelection;
        private System.Windows.Forms.Button ButtonNewPlayer;
        private System.Windows.Forms.Button ButtonAcceptSelection;
        private System.Windows.Forms.Button ButtonAbortSelection;
        private System.Windows.Forms.GroupBox GroupBoxPlayer1;
        private System.Windows.Forms.TextBox TextBoxInvestigator;
        private System.Windows.Forms.TextBox TextBoxPlayerName;
        private System.Windows.Forms.Button ButtonChooseInvestigator;
        private System.Windows.Forms.Button ButtonAcceptPlayer;
        private System.Windows.Forms.Button ButtonAbortPlayer;
    }
}

