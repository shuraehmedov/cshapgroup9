using Lessons13.Model;
using System.Globalization;

namespace Lessons13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            // dog.SetBrein(12);

            // dog._brein = "100";

            //Console.WriteLine(dog.GetBrein());

            dog.Brein = 100;
            Console.WriteLine(dog.Brein);
        }
    }
}
