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
            int  depthAttachment = 0;

            char[] symbol = new char[] { '(', '(', ')' };

            for (int i = 0; i < symbol.Length; i++)
            {
                Console.Write($"{symbol[i]}");
            }

            for (int i = 0; i < symbol.Length; i++)
            { 
                if (symbol[0] ==closingBracket)
                {
                    Console.WriteLine($"Не является корректным скоточным выражением.");
                    Console.ReadKey();
                    break;
                }


            }


        }
    }
}
