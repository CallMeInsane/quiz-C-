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
        //Sounds
        SoundPlayer correct = new SoundPlayer("correct.wav");
        SoundPlayer wrong = new SoundPlayer("wrong.wav");

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
                correct.Play();
            }
            else
            {
                Console.WriteLine("No.");
                wrong.Play();
            }

            break;

            //Subtracting
            case "-":
            int answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 == num1-num2)
            {
                Console.WriteLine("Correct! " + answer2);
                correct.Play();
            }
            else
            {
                Console.WriteLine("No.");
                wrong.Play();
            }
            break;

            //Multiplying
            case "*":
            int answer3 = Convert.ToInt32(Console.ReadLine());
            if (answer3 == num1*num2)
            {
                Console.WriteLine("Correct! " + answer3);
                correct.Play();
            }
            else
            {
                Console.WriteLine("No.");
                wrong.Play();
            }
            break;

            //Dividing
            case "/":
            int answer4 = Convert.ToInt32(Console.ReadLine());
            if (answer4 == num1*num2)
            {
                Console.WriteLine("Correct! " + answer4);
                correct.Play();
            }
            else
            {
                Console.WriteLine("No.");
                wrong.Play();
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
