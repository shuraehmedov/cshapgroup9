namespace Lessons13.Model
{
    public class Animal
    {
        public string name;
        public string voice;

        public int Run()
        {
            return 100;
        }

        public virtual int Move()
        {
            return 10;
        }
    }
}
