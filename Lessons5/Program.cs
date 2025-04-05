namespace Lessons5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ulduz = "*";
            int say = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine(ulduz);
                ulduz += "*";
            }
        }

        /*Console.WriteLine("Ulduz Sayi daxil et:");
        var var1 = Convert.ToInt32(Console.ReadLine());

       var

        for (int i = 1; i <= var1; i++)
        {
          Console.Write("*");


        }
*/



        /*  for(int i = 0; i < 10; i++) { 

          }*/
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
