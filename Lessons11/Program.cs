using System.Runtime.CompilerServices;

namespace Lessons11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(User.x1());


            User.nameLengthMax = 100;


            User user2 = new User();
            user2.name = "Shura";
            user2.surename = "Ehmedov";
           /* Console.WriteLine(user2.FullName());*/

            User user1 = new User("Cavid", "Babazade");
          /*  Console.WriteLine(user1.FullName());*/

            /* User[] UserArray = new User[10];

             foreach (user in UserArray)
             {
                 user.name = Console.ReadLine();
                 user.surename = Console.ReadLine();
                 Console.WriteLine(user.FullName());
             }*/



            Console.ReadLine();
        }
    }

    class User
    {
        public string name;
        public string surename;
        public static int nameLengthMax;

        public User(string name, string surename)
        {
            this.name = name;
            this.surename = surename;
        }

        public User(){}

        public string FullName()
        {
            return name + " " + surename + " Max Name:" +nameLengthMax.ToString();
        }

        public static string x1()
        {
            return name + " " + surename;
        }
    }


}
