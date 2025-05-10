using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons12.Model
{
    class Animal
    {
        public string name;
        public string color;

        public Animal(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        protected int TestMethod()
        {
            return 12;
        }

    }
}
