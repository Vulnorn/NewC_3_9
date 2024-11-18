using System;

namespace NewC_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbols = "((())((())))";
            char openingBracket = '(';
            char closingBracket = ')';
            int correctExpression = 0;
            int deep = 0;

            Console.WriteLine($"{symbols}");

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == openingBracket)
                {
                    correctExpression++;

                    if (correctExpression > deep)                   
                        deep = correctExpression;                  
                }
                else if (symbols[i] == closingBracket)
                {
                    correctExpression--;

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