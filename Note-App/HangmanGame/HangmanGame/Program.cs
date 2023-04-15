using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace HangmanGame
{
    public class Program
    {
        private static void printHangmane(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("     \n+---+");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("         ===");

            }
            else if (wrong == 1)
            {
                Console.WriteLine("      \n+---+");
                Console.WriteLine("        0  |");
                Console.WriteLine("           |");
                Console.WriteLine("           |");
                Console.WriteLine("          ===");

            }
            else if (wrong == 2)
            {
                Console.WriteLine("      \n+---+");
                Console.WriteLine("        0  |");
                Console.WriteLine("        |  |");
                Console.WriteLine("           |");
                Console.WriteLine("          ===");

            }
            else if (wrong == 3)
            {
                Console.WriteLine("      \n+---+");
                Console.WriteLine("        0  |");
                Console.WriteLine("       /|  |");
                Console.WriteLine("           |");
                Console.WriteLine("          ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("      \n+---+");
                Console.WriteLine("        0   |");
                Console.WriteLine("       /|\\ |");
                Console.WriteLine("            |");
                Console.WriteLine("           ===");
            }
            else if (wrong == 5)
            {

            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("  0   |");
                Console.WriteLine(" /|\\ |");
                Console.WriteLine(" /    |");
                Console.WriteLine("     ===");
            }
        }

        private static int printWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetter = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.WriteLine(c + " ");
                    rightLetter++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetter;
        }
        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("\u0305");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("----------------------------------------");

            Random random = new Random();
            List<string> WordDictonary = new List<string>
            {
                "sunflower",
                "house",
                "diamond",
                "memes",
                "yeet",
                "door",
                "codefun"
            };
            int index = random.Next(WordDictonary.Count);
            String randomWord = WordDictonary[index];

            foreach (char c in randomWord)
            {
                Console.Write("_ ");
            }
            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> curentletterGuessed = new List<char>();
            int currentLetterRight = 0;

            while (amountOfTimesWrong != 6 && currentLetterRight != lengthOfWordToGuess)
            {
                Console.Write("\n Letter guessed so far");
                foreach (char letter in curentletterGuessed)
                {
                    Console.WriteLine(letter + " ");
                }

                Console.Write("Guess a letter: ");
                char letterGuessed = Console.ReadLine()[0];
                if (curentletterGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n You have alredy guessed this letter");
                    printHangmane(amountOfTimesWrong);
                    currentLetterRight = printWord(curentletterGuessed, randomWord);
                    printLines(randomWord);
                }
                else
                {
                    bool right = false;
                    for (int i = 0;i < randomWord.Length;i++)
                    {
                        if(letterGuessed == randomWord[i])
                        {
                          right = true;
                        }
                    }
                    if (right)
                    {
                        printHangmane(amountOfTimesWrong);
                        curentletterGuessed.Add(letterGuessed);
                        currentLetterRight = printWord(curentletterGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);

                    }
                    else
                    {
                        amountOfTimesWrong++;
                        curentletterGuessed.Add(letterGuessed);
                        printHangmane(amountOfTimesWrong);
                        currentLetterRight = printWord(curentletterGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);

                    }
                }
            }
            Console.WriteLine("\r\n Game over !\n Thank you for playng");
        }
    }
}
