using System;
using System.Net.Mail;

namespace NewC_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char openingBracket = '(';
            char closingBracket = ')';

            int correctExpression = 0;

            char[] symbols = new char[] { '(', '(', ')',')' };

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write($"{symbols[i]}");
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == openingBracket)
                {
                    correctExpression--;
                }
                else if (symbols[i] == closingBracket)
                {
                    correctExpression++;
                    if (correctExpression == 1)
                    {
                        break;
                    }
                }
            }

            char currentChar = symbols[0];
            int currentRepeatCount = 0;
            int deep = 0;

            if (correctExpression != 0)
            {
                Console.WriteLine($"\nСкобочное выражение - некорректное");
            }
            else
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i] == currentChar)
                    {
                        currentRepeatCount++;

                        if (currentRepeatCount > deep)
                        {
                            deep = currentRepeatCount;
                        }
                    }
                    else
                    {
                        currentChar = symbols[i];
                        currentRepeatCount = 1;
                    }
                }

                Console.WriteLine($"\nСкобочное выражение - корректное, глубина равна {deep}");
            }

            Console.ReadKey();
        }
    }
}