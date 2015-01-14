﻿using System;

/*
   Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
    You might need to learn how to use loops in C# (search in Internet).
*/

class PrintLongSequence
{
    static void Main()
    {
        
        int number = 2;
        Console.SetBufferSize(80, 1000);
        for (int i = number; i <= 100; i++)
         {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " " );
            }
                else
                {
                    Console.WriteLine(-i +" ");
                }
         }
    }
}


