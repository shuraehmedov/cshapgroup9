namespace Lessons9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[] array = { 3, 5, 2, 6, 1, 7, 8 };*/

            int[,] arrayTwo =
            {
                {1,2,3,4},
                {2,4,5,6}
            };

            int b= arrayTwo[0,2];


            Console.WriteLine(b);



            /*     for (int i = 0; i < array.Length; i++)
                 {
                     for (int j = 0; j < array.Length; j++)
                     {
                         if (array[i] > array[j])
                         {
                             int a = array[i];
                             array[i] = array[j];
                             array[j] = a;
                         }
                     }
                 }

                 for (int i = 0; i< array.Length; i++)
                 {
                     Console.WriteLine(array[i]);
                 }  */
        }
    }
}
