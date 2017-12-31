using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EldritchHorror
{
    static class Program
    {
        static MainForm MyForm;
        public static List<Investigator> Investigators;
        public static List<Player> Players;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupGame();
            Players = new List<Player>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm = new MainForm();
            Application.Run(new MainForm());
        }

        public static void SetupGame()
        {
            Investigators = new List<Investigator>
            {
                new Investigator("John Kain", 56, "Los Angeles", 4, 8, 2, 4, 3, 1, 3),
                new Investigator("Lara Croft", 34, "Tokyo", 4, 8, 2, 4, 3, 1, 3)
            };

            CardHandler.InitDecks();
            CardHandler.FillReserve();
        }

        public static bool ChooseInvestigator(Investigator investigator)
        {
            int investigatorId = Investigators.FindIndex(f => f.Name == investigator.Name);
            if (investigatorId >= 0)
            {
                return Investigators.ElementAt(investigatorId).GiveToPlayer(0);
            }
            return false;
        }
    }
}
