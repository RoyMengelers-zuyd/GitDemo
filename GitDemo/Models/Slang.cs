using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo.Models
{
    internal class Slang: Dier
    {
        public Slang(string naam) : base(naam)
        {
        }

        public override string Bewegen()
        {
            return "Slang kruipt vooruit";
        }
    }
}
