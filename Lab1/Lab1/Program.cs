using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         Name: Grant Balonier
         Title: IT-1050 – Lab 1
        */

        // Step 2
        Console.WriteLine("Grant Balonier");
        Console.WriteLine("IT-1050 – Lab 1");

        // Step 3
        int favoriteNumber = 42;
        string favoriteLanguage = "None (I'm just getting started!)";
        double programsWritten = 0;
        bool hasExperience = false;

        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Favorite Programming Language: " + favoriteLanguage);
        Console.WriteLine("Programs Written Before This: " + programsWritten);
        Console.WriteLine("Do you have programming experience? " + hasExperience);

        // Step 4
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School Name: " + schoolName);

        // Step 5
        double myDouble = 9.78;
        int myInt = (int)myDouble;

        Console.WriteLine("Double (original): " + myDouble);
        Console.WriteLine("Int (after casting): " + myInt);

        int numberToConvert = 100;
        bool boolToConvert = true;

        string intAsString = Convert.ToString(numberToConvert);
        string boolAsString = Convert.ToString(boolToConvert);

        Console.WriteLine("Int to String: " + intAsString);
        Console.WriteLine("Bool to String: " + boolAsString);

        // Step 6
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + userName + "! You are " + userAge + " years old.");

        // Step 7
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));
        // Step 8
float myFloat = 1.123456789f;
double myDoublePrecision = 1.123456789;

Console.WriteLine("Float value: " + myFloat);
Console.WriteLine("Double value: " + myDoublePrecision);
// Step 9
int count = 10;

count++;
Console.WriteLine("After increment: " + count);

count--;
Console.WriteLine("After decrement: " + count);
    }
}