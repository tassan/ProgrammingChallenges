using System;
using System.Globalization;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number");
            var inputFirstNumber = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            var inputSecondNumber = Console.ReadLine();

            int firstNumber = Convert.ToInt32(inputFirstNumber);
            int secondNumber = Convert.ToInt32(inputSecondNumber);
            Console.WriteLine($"{inputFirstNumber} + {inputSecondNumber} = {firstNumber + secondNumber}\n" +
                              $"{inputFirstNumber} - {inputSecondNumber} = {firstNumber - secondNumber}\n" +
                              $"{inputFirstNumber} * {inputSecondNumber} = {firstNumber * secondNumber}\n" +
                              $"{inputFirstNumber} / {inputSecondNumber} = {firstNumber / secondNumber}\n");
        }
    }
}