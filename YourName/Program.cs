using System;

namespace YourName
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var output = $"Hello, {name}, nice to meet you!";
            Console.WriteLine(output);
        }
    }
}