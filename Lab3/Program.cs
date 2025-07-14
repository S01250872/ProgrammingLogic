using System;

class Program
{
    static void Main()
    {
        // -----------------------
        // Problem 1: Simple For Loop
        // -----------------------
        Console.WriteLine("Problem 1: For Loop 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // -----------------------
        // Problem 2: Even Numbers from 1 to 20
        // -----------------------
        Console.WriteLine("\nProblem 2: Even Numbers from 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // -----------------------
        // Problem 3: While Loop Countdown
        // -----------------------
        Console.WriteLine("\nProblem 3: Countdown from 5 to 1");
        int countdown = 5;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        // -----------------------
        // Problem 4: Multiples of 10 (10 to 1000)
        // -----------------------
        Console.WriteLine("\nProblem 4: Multiples of 10 (10 to 1000)");
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        // -----------------------
        // Problem 5: Seasons of the Year
        // -----------------------
        Console.WriteLine("\nProblem 5: Seasons of the Year");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // -----------------------
        // Problem 6: Days of the Week (1–7)
        // -----------------------
        Console.WriteLine("\nProblem 6: Days of the Week (1–7)");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int dayIndex) && dayIndex >= 1 && dayIndex <= 7)
        {
            Console.WriteLine($"That day is: {days[dayIndex - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }

        // -----------------------
        // Problem 7: Favorite Books and Authors
        // -----------------------
        Console.WriteLine("\nProblem 7: Favorite Books and Authors");
        string[] books = { "1984", "The Hobbit", "To Kill a Mockingbird" };
        string[] authors = { "George Orwell", "J.R.R. Tolkien", "Harper Lee" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        // -----------------------
        // Problem 8: Temperature Tracker
        // -----------------------
        Console.WriteLine("\nProblem 8: Temperature Tracker");
        int[] temps = { 68, 74, 59, 80, 65 };
        Array.Sort(temps);
        Console.WriteLine("Sorted temperatures:");
        foreach (int t in temps)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine($"Lowest temperature: {temps[0]}");
        Console.WriteLine($"Highest temperature: {temps[temps.Length - 1]}");

        // -----------------------
        // Problem 9: Reverse Countdown
        // -----------------------
        Console.WriteLine("\nProblem 9: Reverse Countdown");
        int[] reverseCountdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(reverseCountdown);
        for (int i = 0; i < reverseCountdown.Length; i++)
        {
            Console.WriteLine(reverseCountdown[i]);
        }
    }
}