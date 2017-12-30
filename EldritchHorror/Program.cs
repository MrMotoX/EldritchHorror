using System;
using System.Security.Cryptography;
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
            Assets = new List<Asset>();
            AssetsReader = new BoxContentParser("BoxContent/assets.xml");
            InitCards(ref AssetsReader, ref Assets);
        }

        private struct CardInfo
        {
            public string Name;
            public List<string> Traits;
            public int Cost;

            public CardInfo(string name)
            {
                Name = name;
                Traits = new List<string>();
                Cost = 0;
            }
        }

        private static void InitCards(ref BoxContentParser reader, ref List<Asset> assets)
        {
            CardInfo card = new CardInfo("");

            while (reader.Reader.Read())
            {
                UpdateCardInfo(ref reader, ref card);

                if (EndOfCardInfo(ref reader))
                {
                    assets.Add(new Asset(card.Name, card.Traits, card.Cost));

                    card = new CardInfo("");
                }
            }
        }

        private static void UpdateCardInfo(ref BoxContentParser reader, ref CardInfo card)
        {
            if (reader.Reader.NodeType == XmlNodeType.Element)
            {
                if (reader.Reader.Name == "Name")
                {
                    card.Name = reader.Reader.ReadElementContentAsString();
                }

                if (reader.Reader.Name == "Trait")
                {
                    card.Traits.Add(reader.Reader.ReadElementContentAsString());
                }

                if (reader.Reader.Name == "Cost")
                {
                    card.Cost = reader.Reader.ReadElementContentAsInt();
                }
            }
        }

        private static bool EndOfCardInfo(ref BoxContentParser reader)
        {
            return reader.Reader.NodeType == XmlNodeType.EndElement && reader.Reader.Name == "Card";
        }

        public static void SetupGame()
        {
            Investigators = new List<Investigator>
            {
                new Investigator("John Kain", 56, "Los Angeles", 4, 8, 2, 4, 3, 1, 3),
                new Investigator("Lara Croft", 34, "Tokyo", 4, 8, 2, 4, 3, 1, 3)
            };

            AssetDeck = Assets;
            AssetDeck.Shuffle();
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
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
