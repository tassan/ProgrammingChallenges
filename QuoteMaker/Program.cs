using System;

namespace QuoteMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the quote?");
            var quote = Console.ReadLine();
            Console.WriteLine("Who said it?");
            var author = Console.ReadLine();
            
            Console.WriteLine(author + " says, \"" + quote + "\"");
        }
    }
}