using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            String HelloWorld = "Hello World!";

            for(int i = 0; 1 < HelloWorld.Length; i++)
            {
                Console.WriteLine($"kohal {i} on {HelloWorld[i]}");
            }
        }
    }
}
