using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a noun: ");
            var noun = Console.ReadLine();
            Console.WriteLine("Enter a verb: ");
            var verb = Console.ReadLine();
            Console.WriteLine("Enter a adjective: ");
            var adjective = Console.ReadLine();
            Console.WriteLine("Enter a adverb: ");
            var adverb = Console.ReadLine();

            Console.WriteLine($"Do you {verb} your {adjective} {noun} {adverb}? That's hilarious!");
        }
    }
}