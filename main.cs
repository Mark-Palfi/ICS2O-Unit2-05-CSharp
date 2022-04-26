// Created by: Mark Palfi
// Created on: Mar 2022
//
// This program does math 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double salary;
        double hours;
        double pay;
        double taxes;


        Console.WriteLine("This program calculates the pay and taxes of the user.");

        // input
        Console.Write("Enter salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter salary: ");
        hours = Convert.ToDouble(Console.ReadLine());

        // process
        pay = hours * salary * (1.00 - 0.18);
        taxes = hours * salary * 0.18;

        // output
        Console.WriteLine("Your pay is = $" + pay + "");
        Console.WriteLine("You're taxed = $" + taxes + "");

        Console.WriteLine("\nDone.");
    }
}