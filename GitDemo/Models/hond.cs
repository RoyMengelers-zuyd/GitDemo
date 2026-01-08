using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo.Models
{
    internal class hond : Dier
    {
        public int Aantalpoten { get; private set; }
        public bool Veelgeld { get;  set; }

        public string Blaffen { get;  set; } = "tijn blaft veel";
        public hond(string naam, int aantalpoten, bool veelgeld, string blaffen) : base(naam)
        {
            Aantalpoten = aantalpoten; 
            Veelgeld = veelgeld;
            Blaffen = blaffen;
        }
        public override string Bewegen()
        {
            if (Veelgeld == false)
            {
                return "kan niet bewegen want is gehandicapd";
            }
            else
            {
                return "kan bewegen";
            }
        }
    }
}

