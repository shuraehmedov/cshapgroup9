using static System.Net.Mime.MediaTypeNames;

namespace Lessons10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine(Sum(1, 3, 4, 5, 5,6));*/
            /* var var1 = 10;
             Test1(ref var1);*/

            /*string var2 = Test2(0, out bool a);*/

            /*            var b = Test3(10);
                        Console.WriteLine(b.isOk);*/
            var var1 = Test3(12);

            Console.WriteLine(var1.value);
            Console.ReadLine();

        }


        /*     static void Sum(int var1, int var2 = 1)
             {
                 Console.WriteLine(var1 * var2);
             }*/

        static int Sum(params int[] var1)
        {
            int sum = 0;
            for (int i = 0; i < var1.Length; i++)
            {
                sum += var1[i];
            }

            return sum;
        }

        static int Test1(ref int a)
        {
            a = a + 1;  //11
            return a * 2;
        }

        static string Test2(int var1, out bool isOk)
        {
            if (var1>0)
            {
                isOk = true;
                return "dogrudur";
            }
            else
            {
                isOk = false;
                return "sehvdir";
            }
        }

        static (int ilkDeyer, bool isOk, string value) Test3(int a)
        {
            if (a > 0)
            {
                return (a * a, true, "salam dunya");
            }
            else { 
                return (0, false, "Salam dunya");
            }
        }

        static int test4(int var1)
        {
            return var1 * 2;
        }

        static string test4(string var1)
        {
            return var1.ToString() + " Salam Cavid";
        }
    }
}
