using System.Reflection.Metadata.Ecma335;

namespace GitDemo.Models
{
    internal class Meeuw : Dier
    {
        private decimal snelheid = 103.44m;
        public Meeuw(string naam) : base(naam)
        {
        }

        public override string Bewegen()
        {
            return $"{Naam} vliegt met een maximumsnelheid van: {snelheid} km/h";
        }
    }
}
