using System;

namespace ConsoleApplication
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, you passed in the following arguments:");

            foreach (var arg in args)
                Console.WriteLine("\t{0}", arg);

            Console.WriteLine("Goodbye");
        }
    }
}
