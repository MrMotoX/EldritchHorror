using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorror
{
    public class Investigator
    {
        private string strName;
        private int age;
        private string startingLocation;
        private int maxHealth;
        private int maxSanity;
        private Trait lore;
        private Trait influence;
        private Trait observation;
        private Trait strength;
        private Trait wisdom;
        private int belongsToPlayer;

        public Investigator(string newName, int newAge, string newStartingLocation, int newMaxHealth, int newMaxSanity, int newLore, int newInfluence, int newObservation, int newStrength, int newWisdom)
        {
            strName = newName;
            age = newAge;
            startingLocation = newStartingLocation;
            maxHealth = newMaxHealth;
            maxSanity = newMaxSanity;
            lore = new Trait(newLore);
            influence = new Trait(newInfluence);
            observation = new Trait(newObservation);
            strength = new Trait(newStrength);
            wisdom = new Trait(newWisdom);
            belongsToPlayer = -1;
        }

        public string Name
        {
            get
            {
                return strName;
            }
        }

        public int BelongsToPlayer
        {
            get
            {
                return belongsToPlayer;
            }
        }

        public bool GiveToPlayer(int playerId)
        {
            if (belongsToPlayer < 0)
            {
                belongsToPlayer = playerId;
                return true;
            }
            return false;
        }
    }
}
