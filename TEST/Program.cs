using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\t\t\t\t\tLyrics of the song 99 Bottles of Beer\r");
            Console.WriteLine("\t\t\t\t\t-------------------------------------");
            Console.WriteLine("");

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"Take one down and pass it around, {i} bottles of beer on the wall.");
                Console.WriteLine("");
                Console.WriteLine($"{i - 1} bottles of beer on the wall, {i - 1} bottles of beer.");
                if(i == 1)
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer. Take one down and pass it around,no more bottles of beer on the wall.");
                    Console.WriteLine("");
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                    Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
                }





            }
        }
    }
}
