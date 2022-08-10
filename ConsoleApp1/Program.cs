using System;
using ExtensionMethods.Contracts;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Starting: {DateTime.Now.Format()}");
            Console.WriteLine($"Starting: {DateTime.Now.ToUnixSeconds()}");
            Console.ReadLine();
        }
    }
}
