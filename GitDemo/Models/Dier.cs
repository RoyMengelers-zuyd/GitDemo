namespace GitDemo.Models
{
    internal abstract class Dier
    {
        public string Naam { get; private set; }

        protected Dier(string naam)
        {
            Naam = naam;
        }

        public abstract string Bewegen();
    }
}
