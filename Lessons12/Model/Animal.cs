using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons12.Model
{
    class Animal
    {
        public string Name;
        public string Color;

        private string _year;

        public Animal(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        protected int TestMethod()
        {
            return 12;
        }

    }
}
