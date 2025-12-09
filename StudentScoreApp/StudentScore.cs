using System;
using System.Collections.Generic;
using System.Text;

namespace StudentScoreApp
{
    public static class StudentScore
    {
        // Method 1: Get the student's name

         public static string GetStudentName()
        {
            Console.Write("Enter student name: ");
            string? name = Console.ReadLine();

            // If the user enters nothing, use "Unknown"
            if (string.IsNullOrWhiteSpace(name))
                return "Unknown";

            return name;
        }

        // Method 2: Ask how many scores the user wants to enter

        public static int GetScoreCount()
        {
            int count = 0;

            while (true)
            {
                Console.Write("How many scores do you want to enter? ");
                string? input = Console.ReadLine();

                // Check if input is a valid number greater than 0
                if (int.TryParse(input, out count) && count > 0)
                    return count;

                Console.WriteLine("Please enter a valid number greater than 0.");
            }
        }


        // Method 3: Collect scores one-by-one

        public static List<int> GetScores(int count)
        {
            List<int> scores = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int score = 0;

                while (true)
                {
                    Console.Write($"Enter score {i + 1}: ");
                    string? input = Console.ReadLine();

                    // Check if input is a number
                    if (int.TryParse(input, out score))
                    {
                        scores.Add(score); // Add the score to the list
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return scores;
        }


        // Method 4: Print scores in a table and show total

        public static void PrintScoreTable(string name, List<int> scores)
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine($" Scores for: {name}");
            Console.WriteLine("===============================");
            Console.WriteLine("Index\tScore");

            int total = 0;

            // Print each score and calculate total
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{scores[i]}");
                total += scores[i];
            }

            Console.WriteLine("===============================");
            Console.WriteLine($"Total Score: {total}");
            Console.WriteLine("===============================");
        }
    }
}
