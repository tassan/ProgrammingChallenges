using System;

namespace NumberOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the input string?");
            var input = Console.ReadLine();
            Console.WriteLine($"{input} has {input.Length} characters.");
        }
    }
}