using System;

namespace Bottlesong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 1; i--)

            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.Take one down and pass it around, {i - 1} bottles of beer on the wall.");
            }
        }
    }
}
