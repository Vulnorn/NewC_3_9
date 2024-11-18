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
            int deep = 0;
            int maxDeep = 0;

            Console.WriteLine($"{symbols}");

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == openingBracket)
                {
                    deep++;

                    if (deep > maxDeep)                   
                        maxDeep = deep;                  
                }
                else if (symbols[i] == closingBracket)
                {
                    deep--;

                    if (deep < 0)
                        break;
                }
            }

            if (deep != 0)
                Console.WriteLine($"\nСкобочное выражение - некорректное");
            else
                Console.WriteLine($"\nСкобочное выражение - корректное, глубина равна {maxDeep}");

            Console.ReadKey();
        }
    }
}