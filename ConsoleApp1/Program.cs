using System;
using System.Formats.Asn1;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.IO;
using System.Diagnostics;
#pragma warning disable CA1416 // Validate platform compatibility

public class Program
{
    public static void Main(string[] args)
    {
        //Math
        Random rnd = new Random();
        int num1 = rnd.Next(0, 100);
        int num2 = rnd.Next(0, 100);

        //Console
        Console.WriteLine("Your numbers are " + num1 + " and " + num2);
        Console.WriteLine("What do you want to do with it? + - * /");
        string? operation = Console.ReadLine();
        
        Console.WriteLine("Write your answer.");

        //Calculations/Solving
        switch (operation)
        {
            //Adding
            case "+":
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == num1+num2)
            {
                Console.WriteLine("Correct! " + answer);
            }
            else
            {
                Console.WriteLine("No.");
            }

            break;

            //Subtracting
            case "-":
            int answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 == num1-num2)
            {
                Console.WriteLine("Correct! " + answer2);
            }
            else
            {
                Console.WriteLine("No.");
            }
            break;

            //Multiplying
            case "*":
            int answer3 = Convert.ToInt32(Console.ReadLine());
            if (answer3 == num1*num2)
            {
                Console.WriteLine("Correct! " + answer3);
            }
            else
            {
                Console.WriteLine("No.");
            }
            break;

            //Dividing
            case "/":
            int answer4 = Convert.ToInt32(Console.ReadLine());
            if (answer4 == num1*num2)
            {
                Console.WriteLine("Correct! " + answer4);
            }
            else
            {
                Console.WriteLine("No.");
            }
            break;

            //Defaukt
            default:
            Console.WriteLine("That is not the right answer :sob:");
            break;
        }

        Console.ReadKey();
    }
}
