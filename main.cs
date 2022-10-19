// Created by: Allen
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        float hourlyRate;
        float numberOfHours;
        float payment;
        float taxesToGoverment;

        Console.WriteLine("This program is about salary program");
        Console.WriteLine("");

        Console.Write("Number of hours worked: ");
        numberOfHours = Convert.ToSingle(Console.ReadLine());
        Console.Write("Hourly rate:$ ");
        hourlyRate = Convert.ToSingle(Console.ReadLine());

        payment = (numberOfHours * hourlyRate) * ((float)1.00 - (float)0.18);
        taxesToGoverment = (numberOfHours * hourlyRate) * ((float)0.18);

        Console.WriteLine("");
        Console.WriteLine("Your pay will be: $" + payment + ".");
        Console.WriteLine("The goverment will take: $" + taxesToGoverment + ".");

        Console.WriteLine("\nDone.");
    }
}
