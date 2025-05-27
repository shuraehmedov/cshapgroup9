using System.Drawing;

namespace Lessons14
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Sh var1 = "salam";
            Console.WriteLine(var1.Value);
        }
       static void Main1(string[] args)
        {

            int a = 10;

            //referans
            User1 user1 = new User1(); 
            user1.Name = "Cavid";
            user1.Year = 20;

            var user2 = user1; // value type
            user2.Name = "Shura";


            Console.WriteLine("Adi:"+user1.Name);
            Console.WriteLine("Yashi:"+user1.Year);

            Console.WriteLine("Adi:" + user2.Name);
            Console.WriteLine("Yashi:" + user2.Year);
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public struct User1
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public struct Sh
    {
        private string _value;

        public int Lenghth => _value?.Length ?? 0;

        public string Value => _value;

        public Sh(string value)
        {
            _value = value;
        }

        public static implicit operator Sh(string value) => new Sh(value);
    }
}
