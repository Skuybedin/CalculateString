using System;

namespace CalculateStringConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculate calc = new CalculateString("Привет, как дела? !!");
            Console.WriteLine($"Количество слов в предложении: {calc.CalcWordCount()}");
            Console.WriteLine($"Количество гласных в предложении: {calc.CalcVowelCount()}");
            Console.WriteLine($"Язык: {calc.GetLanguage()}");

            Console.ReadLine();
        }
    }
}
