using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Lessons12.Model;

namespace Lessons12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // private
            // proteced
            // public
            // internal
            // protected internal

            Animal heyvan = new Animal("Pitbull", "Qara");


            Dog dog1 = new Dog("Pitbull", "Qara", 12);

            Console.WriteLine(dog1.info());

        

            Console.WriteLine(dog1.Information());

          //  Dog dog2 = new Dog();
          /*  dog2.name = "Pitbull";
            dog2.color = "Qara";*/
           // Console.WriteLine(dog2.Information());

        }
    }



}


