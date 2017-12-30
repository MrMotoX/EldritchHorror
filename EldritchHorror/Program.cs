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
        public static List<Asset> Assets, AssetDeck, AssetDiscard, Reserve;
        public static BoxContentParser AssetsReader;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitBoxContent();

            SetupGame();
            Players = new List<Player>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm = new MainForm();
            Application.Run(new MainForm());
        }

        private static void InitBoxContent()
        {
            InitCards();
        }

        private static void InitCards()
        {
            Assets = new List<Asset>();
            AssetsReader = new BoxContentParser("BoxContent/assets.xml");

            string name = "";
            List<string> traits = new List<string>();
            int cost = 0;

            while (AssetsReader.Reader.Read())
            {
                if (AssetsReader.Reader.NodeType == XmlNodeType.Element)
                {
                    if (AssetsReader.Reader.Name == "Name")
                    {
                        name = AssetsReader.Reader.ReadElementContentAsString();
                    }

                    if (AssetsReader.Reader.Name == "Trait")
                    {
                        traits.Add(AssetsReader.Reader.ReadElementContentAsString());
                    }

                    if (AssetsReader.Reader.Name == "Cost")
                    {
                        cost = AssetsReader.Reader.ReadElementContentAsInt();
                    }
                }

                if (AssetsReader.Reader.NodeType == XmlNodeType.EndElement && AssetsReader.Reader.Name == "Card")
                {
                    Assets.Add(new Asset(name, traits, cost));

                    name = "";
                    traits = new List<string>();
                    cost = 0;
                }
            }
        }

        public static void SetupGame()
        {
            Investigators = new List<Investigator>
            {
                new Investigator("John Kain", 56, "Los Angeles", 4, 8, 2, 4, 3, 1, 3),
                new Investigator("Lara Croft", 34, "Tokyo", 4, 8, 2, 4, 3, 1, 3)
            };

            ResetAssets();
            ShuffleAssetDeck();
        }

        private static void ResetAssets()
        {
            if (AssetDeck == null)
            {
                AssetDeck = new List<Asset>();
            }
            else
            {
                AssetDeck.Clear();
            }
        }

        private static void ShuffleAssetDeck()
        {
            throw new NotImplementedException();
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
