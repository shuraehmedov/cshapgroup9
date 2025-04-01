namespace Lessons4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Riyazi operatorlar: +, -, *, /, ++, --
            var var1 = 10;
            var var2 = 20;

            // muqayise operatorlari: ==, !=, <, >, <=, >=

            //mentiqi opeartoru: &&, ||, !

            int var3 = 10;
            int var4 = 10;

            bool isOk = var1 != var2 || var3 == var4;

            if (isOk)
            {
                // Console.WriteLine(var1 + var2);
            }else if (var1 == var2)
            {
               // Console.WriteLine("else if");
            }
            else if (var1 == var2)
            {
                // Console.WriteLine("else if");
            }
            else if (var1 == var2)
            {
                // Console.WriteLine("else if");
            }
            else
            {

            }

            // ternary operator: ? :

            var var6 = var3 == var4 ? "dogrudur" : "yalnishdir";

            Console.WriteLine(var6 );

            // aritmatik operatorlar: ++ , --

            var var5 = 10;

            //Console.WriteLine(var5++); 
            // Console.WriteLine(++var5);  eyni qayda ile --

            //var a = sizeof(float);

            var a = Math.Abs(4); //  riyazi Class

            // Console.WriteLine(a);

            String txt1 =  Console.ReadLine();
            String txt2 = "Dunya";

            // Console.WriteLine("Salam\tDunya");

            // swich

            switch(txt1)
            {
                case "a1": Console.WriteLine("textq a1 dir"); break;
                case "a2": Console.WriteLine("text a2 dur"); break;
                default : Console.WriteLine("Textyoxdur") ; break;
            }

        }

        static void Main(string[] args)
        {
         
            var var1 =Convert.ToInt32(Console.ReadLine());
            var var2 = Convert.ToInt32(Console.ReadLine());
            string operation = Console.ReadLine();

            int? result = null;

            if(operation == "+")
            {
                result = var1 + var2;
            }
            else if(operation == "-")
            {
                result = var1 - var2;
            }
            else if( operation == "*")
            {
                result = var1 * var2;
            }
            else if(operation == "/")
            {
                result = var1 / var2;
            }
            else
            {
                Console.WriteLine("Operator duzgun deyil");
            }

            Console.WriteLine(result);
        }
    }
}
