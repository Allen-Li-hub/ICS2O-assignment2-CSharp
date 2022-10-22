// Created by: Allen
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input4
        int sideaOfTriangle;
        int sidebOfTriangle;
        int sidecOfTriangle;
        int perimeter;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the side A (cm): ");
        sideaOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the side B (cm): ");
        sidebOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the side C (cm): ");
        sidecOfTriangle = Convert.ToInt32(Console.ReadLine());
        
        perimeter = (sidebOfTriangle + sideaOfTriangle + sidecOfTriangle);

        Console.WriteLine("");
        Console.WriteLine("The perimeter is: " + perimeter + " cm. ");

        Console.WriteLine("\nDone.");
    }
}