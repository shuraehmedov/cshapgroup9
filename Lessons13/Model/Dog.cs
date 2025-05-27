using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons13.Model
{
    public class Dog:Animal
    {
        public string Kind;

        private int _brein ;

        public int Brein1 { get; set; }
        public int Brein
        {
            get
            {
                return _brein;
            }
            set
            {
                _brein = value + 50;
            }
        }

        public int GetBrein()
        {
            return _brein;
        }

        public void SetBrein(int brein)
        {
            _brein = brein;
        }



        public int Run()
        {
            return 20;
        }

        public override int Move()
        {
           return base.Move() + 100;
        }
    }
}
