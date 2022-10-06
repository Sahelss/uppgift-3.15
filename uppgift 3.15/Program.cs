using System;

namespace uppgift_3._15
{
    class Program
    {
        public static void Main()
        {
            int y = 80;
            Console.WriteLine("Hur många timmar ska du hyra bilen?");
            int x = int.Parse(Console.ReadLine());


            if (x <= 11)
            {
                Console.WriteLine(y * x + "kr");
                Console.WriteLine("Summa att betala");
            }

            else if (x >= 12)
            {
                Console.Write("Vi hyr inte ut bilar mer än 11 timmar, ange ett annat tal!");
            }
 


        }

    }
}