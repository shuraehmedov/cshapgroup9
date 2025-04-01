namespace Lessons3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicent outo convert
            byte var1 = 10;
            int var2 = var1;
            // Console.WriteLine(var2);

            // explicent manual convert
            int var3 = 200;

            checked
            {
                byte var4 = (byte)var3;
             //   Console.WriteLine(var4);
            }

            // Pare()
            int var5 = int.Parse("55");

            bool ckeckParse = int.TryParse("ww", out int var6);
            if (ckeckParse)
            {
               // Console.WriteLine(var6);
            }
            else
            {
              //  Console.WriteLine("inte cevirmek olmur");
            }

            //convert class
            int var7 = Convert.ToInt32("2234");
            // Console.WriteLine(var7);


            //toString()
            string var8 = var1.ToString();
            Console.WriteLine(var8);

            // nullable
            int? age = null;





        }
    }
}
