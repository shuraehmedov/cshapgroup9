using System.Xml.Serialization;

namespace Lessons5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Boshluqlar
                for (int j = 0; j < n - i - 1; j++)
                {
                     Console.Write(" ");
                }

                int value = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(value + " ");
                    value = value * (i - j) / (j + 1); // Esas dustur
                }

                Console.WriteLine();
            }
        }

        static void Main2(string[] args)
        {


            Console.Write("n daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int row = 1;


            while (count + row <= n)
            {
                Console.WriteLine(new string('*', row));
                count += row;
                row++;
            }

        }
        static void Main1(string[] args)
        {
            //dovr operatorlari
            bool a = false;

            while (a)
            {
                Console.WriteLine("whille");
            }

            do
            {
                //  Console.WriteLine("do whille");
            } while (a);

            // Ededin polindrom olub olmamasini yoxlayaq 122
            Console.WriteLine("Edet daxil et:");
            int var1 = Convert.ToInt32(Console.ReadLine());
            int tam = var1;
            int qaliq;
            string result = "";


            while (tam > 0)
            {
                qaliq = tam % 10; //5,4,2
                tam = tam / 10;   //24,2,0
                result += qaliq;
            }

            if (var1 == Convert.ToInt32(result))
            {
                Console.WriteLine("Palindromdur");
            }
            else
            {
                Console.WriteLine("Palindrom deyil");
            }

            
        }
    }
}
