using GitDemo.Models;

namespace GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meeuw meeuw1 = new Meeuw("Albatros");
            meeuw1.Bewegen();
        }
    }
}
