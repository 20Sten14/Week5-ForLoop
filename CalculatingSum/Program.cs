using System;

namespace CalculatingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++);
            {
                Console.WriteLine("Palun sisestage number");
                int NR1 = Convert.ToInt32(Console.Read());
                sum = sum + NR1;
            }

            Console.WriteLine($"your result is {sum}");







        }
    }
}
