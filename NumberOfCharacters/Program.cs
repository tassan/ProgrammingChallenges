using System;

namespace NumberOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the input string?");
            var input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You must inform the input string!");
                Console.WriteLine("What is the input string?");
                input = Console.ReadLine();
            }
                
            Console.WriteLine($"{input} has {input.Length} characters.");
        }
    }
}