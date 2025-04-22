using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lessons7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int var1= Convert.ToInt32(Console.ReadLine());

            if (IsUnique(var1))
            {
                Console.WriteLine("Unique-dir");
            }
            else{
                Console.WriteLine("Unique deyil");
            }
        }


        static bool IsUnique(int var1)
        {
            string varString = var1.ToString();
            bool isUnique = true; ;
            for (int i = 0; i < varString.Length; i++)
            {
                for (int j = 0; j < varString.Length; j++)
                {
                    if (i != j && varString[i] == varString[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
            }
            return isUnique;
        }


        static void Main1(string[] args)
        {
           // int[] numbers = {1, 2};

            int[] numners2 = new int[3];

            for(int i =0; i < numners2.Length; i++) {
                // numners2[i] = 10;
                numners2[i] = Convert.ToInt32(Console.ReadLine());
            }

            //  add element
            int var1 = 10;
            /*         // Resize ile
                     *//*            Array.Resize(ref numners2, numners2.Length+1);
                                 numners2[numners2.Length - 1] = var1;

                     for (int i = 0; i < numners2.Length; i++)
                     {
                         Console.WriteLine(numners2[i]);
                     }

                      *//*

                     int[] numbers3 = new int[numners2.Length + 1];


                     for (int i = 0; i < numners2.Length; i++)
                     {
                         numbers3[i] = numners2[i];
                     }

                     numbers3[numbers3.Length - 1] = var1;

                     for (int i = 0; i < numbers3.Length; i++)
                     {
                         Console.WriteLine(numbers3[i]);
                     }*/

            // update element

            numners2[1] = 200;
            for (int i = 0; i < numners2.Length; i++)
            {
                Console.WriteLine(numners2[i]);
            }
        }
    }
}
