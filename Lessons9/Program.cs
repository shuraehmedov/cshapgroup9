namespace Lessons9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1,2,3},
                {2,10,5},
                {3,6,7}
            };
            //  ReturnArray(array);

            int arraySize = array.GetLength(0) - 1; //2
            int n = 0;
            int m = 0;
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                m = arraySize - n;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(n==i  && m == j)
                    {
                        sum += array[i, j];
                    }
                   
                }
                n++;
            }

            Console.WriteLine(sum);

        }

        static void ReturnArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
    }
}
