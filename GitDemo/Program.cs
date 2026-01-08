using GitDemo.Models;

namespace GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hond tijn = new Hond("tijn", 2, false, "tijn blaft veel");

            Meeuw meeuw1 = new Meeuw("Albatros");
            meeuw1.Bewegen();
        }
    }
}
