using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldritchHorror
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowSelectionList()
        {
            ListSelection.Visible = true;
            ButtonAcceptSelection.Visible = true;
            ButtonAbortSelection.Visible = true;
        }

        private void HideSelectionList()
        {
            ListSelection.Visible = false;
            ButtonAcceptSelection.Visible = false;
            ButtonAbortSelection.Visible = false;
        }

        private void ShowPlayer()
        {
            TextBoxPlayerName.Visible = true;
            ButtonAcceptPlayer.Visible = true;
            ButtonAbortPlayer.Visible = true;
        }

        private void HidePlayer()
        {
            TextBoxPlayerName.Visible = false;
            ButtonAcceptPlayer.Visible = false;
            ButtonAbortPlayer.Visible = false;
        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonNewPlayer_Click(object sender, EventArgs e)
        {
            ShowPlayer();
        }

        private void ButtonAcceptSelection_Click(object sender, EventArgs e)
        {
            if (Program.ChooseInvestigator(ListSelection.SelectedItem as Investigator))
            {
                TextBoxInvestigator.Text = Program.Investigators.Find(f => f.BelongsToPlayer == 0).Name;
            }
            HideSelectionList();
        }

        private void ButtonAbortSelection_Click(object sender, EventArgs e)
        {
            HideSelectionList();
        }

        private void ButtonAcceptPlayer_Click(object sender, EventArgs e)
        {
            if (TextBoxPlayerName.Text.Length > 0)
            {
                Program.Players.Add(new Player(TextBoxPlayerName.Text));
                GroupBoxPlayer1.Text = TextBoxPlayerName.Text;
                GroupBoxPlayer1.Visible = true;
            }
            HidePlayer();
        }

        private void ButtonChooseInvestigator_Click(object sender, EventArgs e)
        {
            ListSelection.DataSource = Program.Investigators;
            ShowSelectionList();
        }
    }
}
