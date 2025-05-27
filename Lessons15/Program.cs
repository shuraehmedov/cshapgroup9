namespace Lessons15
{
    internal class Program
    {
        // polimorfizm
        static void Main(string[] args)
        {
           // int[] var1 = new int[3];
            Animal[] animals = new Animal[3];

            animals[0] = new Animal("Dovshan");
            animals[1] = new Dog("Boboing", "Kangal");
            animals[2] = new PitBull("Topush", "Coban iti", 100);

            foreach (var aa in animals)
            {
                var var1 = aa as Dog;
                var var2 =(Animal)aa;
              

                if(!(var2 is null))
                {
                  //  Console.WriteLine(var2.Run());
                }

            }
        }
    }

    public class Animal
    {
        public string Name;

        public Animal(string name)
        {
            this.Name = name;
        }
        public virtual String Voice()
        {
            return "Men Heyvanam";
        }
    }

    public class Dog:Animal
    {
        public string Cinsi;

        public Dog(string name,string cinsi):base(name)
        {
            this.Cinsi = cinsi;
        }

        public override String Voice()
        {
            return "Men Item";
        }

        public virtual string Run()
        {
            return Name + " qacir";
        }
    }

    public class PitBull: Dog
    {
        public int Height;

        public PitBull(string name,string cinsi, int height):base(name,cinsi)
        {
            this.Height = height;
        }

        public override String Voice()
        {
            return "Men PitBulam";
        }

        public override string Run()
        {
            return Name + " qacir";
        }
    }


}
