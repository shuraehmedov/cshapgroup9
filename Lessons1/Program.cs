namespace Lessons1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2};

            // Array.Resize(ref arr1, arr1.Length + 1);

            int[] arr2 = new int[3];

            for(var i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

             arr2[arr2.Length - 1] = 100;

             Console.WriteLine(arr2[2]);
            

            Console.ReadLine();
        }
    }
}
