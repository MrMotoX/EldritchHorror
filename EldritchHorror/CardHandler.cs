using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EldritchHorror
{
    static class CardHandler
    {
        private static List<Asset> Assets, AssetsDeck, AssetsDiscard, Reserve;
        private static List<Artifact> Artifacts, ArtifactsDeck, ArtifactsDiscard;
        private static BoxContentParser AssetsReader, ArtifactsReader;

        public struct CardInfo
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

        public static void InitDecks()
        {
            if (Assets == null)
            {
                InitAssets();
            }
            AssetsDeck = new List<Asset>(Assets);
            AssetsDeck.Shuffle();
            AssetsDiscard = new List<Asset>();

            if (Artifacts == null)
            {
                InitArtifacts();
            }
            ArtifactsDeck = new List<Artifact>(Artifacts);
            ArtifactsDeck.Shuffle();
            ArtifactsDiscard = new List<Artifact>();
        }

        private static void InitAssets()
        {
            Assets = new List<Asset>();
            AssetsReader = new BoxContentParser("BoxContent/assets.xml");
            ReadCardsFromConfig(ref AssetsReader, ref Assets);
        }

        private static void InitArtifacts()
        {
            Artifacts = new List<Artifact>();
            ArtifactsReader = new BoxContentParser("BoxContent/artifacts.xml");
            ReadCardsFromConfig(ref ArtifactsReader, ref Artifacts);
        }

        private static void ReadCardsFromConfig(ref BoxContentParser reader, ref List<Asset> assets)
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

        private static void ReadCardsFromConfig(ref BoxContentParser reader, ref List<Artifact> artifacts)
        {
            CardInfo card = new CardInfo("");

            while (reader.Reader.Read())
            {
                UpdateCardInfo(ref reader, ref card);

                if (EndOfCardInfo(ref reader))
                {
                    artifacts.Add(new Artifact(card.Name, card.Traits));

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

        public static void FillReserve()
        {
            if (Reserve == null)
            {
                Reserve = new List<Asset>();
            }

            while (Reserve.Count < 4)
            {
                Reserve.Add(RemoveFirstAssetFromDeckAndReturn());
            }
        }

        public static Asset RemoveFirstAssetFromDeckAndReturn()
        {
            Asset asset = AssetsDeck.First();
            AssetsDeck.Remove(asset);

            return asset;
        }

        public static Asset RemoveAssetByNameFromReserveAndReturn(string name)
        {
            Asset asset = Reserve.Find(x => x.GetName() == name);
            
            throw new NotImplementedException();

            if (asset != null)
            {
                Reserve.Remove(asset);
                return asset;
            }

            return null;
        }
    }
}
