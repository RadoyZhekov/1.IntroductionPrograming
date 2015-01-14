﻿using System;

/*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years*/

class AgeAfterTenYears
{
    static void Main()
    {
        
        Console.WriteLine("Enter the year of your birth :");
        int YearOfBorn = int.Parse(Console.ReadLine());
        int ageNow = DateTime.Now.Year - YearOfBorn;
        Console.Write("Your age now is {0} !\n After 10 years you will be {1} years old !", ageNow, ageNow+10);
    }
}
