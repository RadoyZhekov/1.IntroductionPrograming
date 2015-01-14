using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(-i + " ");
                }
            }
        }
    }
}

/* Второ решение


string[] numbers = { "2, -3, 4, -5, 6, -7, 8, -9, 10" };
        foreach (var num in numbers)
            Console.WriteLine(num);
            Console.ReadLine();
*/