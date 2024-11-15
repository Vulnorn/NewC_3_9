using System;

namespace NewC_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char openingBracket = '(';
            char closingBracket = ')';
            int correctExpression = 0;
            int currentRepeatCountOpeningBracket = 0;
            int deep = 0;

            char[] symbols = new char[] { '(', '(', '(', ')', ')', '(', '(', '(', ')', ')', ')', ')' };

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write($"{symbols[i]}");
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == openingBracket)
                {
                    correctExpression++;
                    currentRepeatCountOpeningBracket++;

                    if (currentRepeatCountOpeningBracket > deep)                   
                        deep = currentRepeatCountOpeningBracket;                  
                }
                else if (symbols[i] == closingBracket)
                {
                    correctExpression--;
                    currentRepeatCountOpeningBracket--;

                    if (correctExpression < 0)
                        break;
                }
            }

            if (correctExpression != 0)
                Console.WriteLine($"\nСкобочное выражение - некорректное");
            else
                Console.WriteLine($"\nСкобочное выражение - корректное, глубина равна {deep}");

            Console.ReadKey();
        }
    }
}