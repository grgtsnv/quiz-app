using System;

class Program
{
    static void Main(string[] args)
    {
        string[] questions = {
        "1. What's the capital city of France?",
        "2. Which planet is known as the Red Planet?",
        "3. Who wrote 'Romeo and Juliet'?",
        "4. What is 12 * 12?",
        "5. What kind of celestial body is the Sun?"
        };

        string[,] options = {
        { "A. Berlin", "B. Madrid", "C. Paris", "D. Rome" },
        { "A. Earth", "B. Venus", "C. Mars", "D. Uranus"},
        { "A. Charles Dickens", "B. William Shakespeare", "C. Mark Twain", "D. Tolkien"},
        { "A. 120", "B. 144", "C. 220", "D. 356"},
        { "A. Planet", "B. Comet", "C. Star", "D. Asteroid"} };

        char[] answers = { 'C', 'B', 'B', 'B', 'C' };

        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            System.Console.WriteLine(questions[i]);
            for (int j = 0; j < 4; j++)
            {
                System.Console.WriteLine(options[i, j]);
            }

            System.Console.Write("Choose your answer (A/B/C/D): ");
            string input = Console.ReadLine().ToUpper();

            if (input.Length == 1 && "ABCD".Contains(input))
            {
                if (input[0] == answers[i])
                {
                    System.Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    System.Console.WriteLine("Incorrect!");
                }
                System.Console.WriteLine("");
            }
            else
            {
                System.Console.WriteLine("Invalid input!. Question skipped.\n");
            }
        }
        System.Console.WriteLine($"Quiz completed! Your score: {score}/{questions.Length}");

        if (score == questions.Length)
        {
            System.Console.WriteLine("Excellent! Perfect score!");
        }
        else if (score >= questions.Length / 2)
        {
            System.Console.WriteLine("Meh. Good job I guess!");
        }
        else
        {
            System.Console.WriteLine("Keep practising!");
        }
    }
}