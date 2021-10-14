using System;
using System.Globalization;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            Console.WriteLine("What is the first number");
            var inputFirstNumber = Console.ReadLine();
            while (!int.TryParse(inputFirstNumber, out firstNumber))
            {
                Console.WriteLine("What is the first number");
                inputFirstNumber = Console.ReadLine();
            }

            Console.WriteLine("What is the second number?");
            var inputSecondNumber = Console.ReadLine();
            while (!int.TryParse(inputSecondNumber, out secondNumber))
            {
                Console.WriteLine("What is the second number?");
                inputSecondNumber = Console.ReadLine();
            }

            Console.WriteLine($"{inputFirstNumber} + {inputSecondNumber} = {firstNumber + secondNumber}\n" +
                              $"{inputFirstNumber} - {inputSecondNumber} = {firstNumber - secondNumber}\n" +
                              $"{inputFirstNumber} * {inputSecondNumber} = {firstNumber * secondNumber}\n" +
                              $"{inputFirstNumber} / {inputSecondNumber} = {firstNumber / secondNumber}\n");
        }
    }
}