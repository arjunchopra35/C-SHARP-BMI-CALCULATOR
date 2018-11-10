/*
 *Author - Arjun Chopra
 *Date - 17th September 2018
 *Program Name = BmiCalculator
 *Program Description - Calculates the Body Mass Index when provided with Height in Inches and Weight in Pounds
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            // Variables
            double heightInches;
            double weightPounds;
            double bodyMassIndex;


            // Prompt the user to enter height in Inches
                Console.Write("Enter your height in Inches: ");

            // Get the Input Weight in Inches
                heightInches = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter weight in Pounds
                Console.Write("Enter your weight in Pound: ");

            // Get the Input in Kilograms
                weightPounds = Convert.ToDouble(Console.ReadLine());

            // Calculate the BMI of the person
                bodyMassIndex = (weightPounds / (heightInches * heightInches))*703;

            //Prompt the BMI result of the person
                Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2}", heightInches , weightPounds, Math.Round(bodyMassIndex, 1));

            //Prompt the user to press any key and exit the application
                Console.WriteLine("\n\nPress any key to end this application..");

            //any Keypress exits application
                Console.ReadKey();


        }
    }
}
