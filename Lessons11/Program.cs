namespace Lessons11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user  = new User();
            user.name = "Cavid";
            user.surename = "Babazade";

            Console.WriteLine(user.FullName());
        }
    }

    class User
    {
        public string name;
        public string surename;

        public string FullName()
        {
            return name + " " + surename;
        }
    }


}
