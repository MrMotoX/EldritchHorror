using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorror
{
    class Asset : Card
    {
        private int Cost;

        public Asset(string name, List<string> traits, int cost) : base(name, traits)
        {
            Cost = cost;
        }
    }
}
