using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons12.Model
{
    class Dog : Animal
    {
        public int say;
        private string cins;
        public Dog(string name,string coler, int say): base(name, coler) { 
            this.say = say;
            cins = "Alman";
        }

        public void Voice()
        {
            Console.WriteLine("Hav Hav");
        }

        public string Information()
        {
            return "Adi:" + name + " Rengi:" + color + " Say:" + say + " :Cins"+ cins;
        }

        public int info()
        {
            return TestMethod();
        }
    }
}
