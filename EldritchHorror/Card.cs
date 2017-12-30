using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorror
{
    class Card
    {
        private string Name;
        private List<string> Traits;

        public Card(string name, List<string> traits)
        {
            Name = name;
            Traits = traits;
        }
    }
}
