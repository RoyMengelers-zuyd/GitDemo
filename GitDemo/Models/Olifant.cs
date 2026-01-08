using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo.Models
{
    internal class Olifant : Dier 
    {
        public Olifant(string naam) : base(naam)
        {
        }

        public override string Bewegen()
        {
            return "De olifant stampt";
        }
    }
}
