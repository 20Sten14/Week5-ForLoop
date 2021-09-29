using System;

namespace Multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {UserNumber} = {i*UserNumber}");
            }
        }
    }
}
