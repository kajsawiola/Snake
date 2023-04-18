﻿namespace SnakeTheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake!");
            MainMenu();
        }
        // Anders kan pusha!
        private static void MainMenu()
        {
            bool continueMenu = true;
            string command;

            while (continueMenu)
            {
                PrintMainMenu();

                command = GetUserInput("Menu choice: ");

                if (command == "play" || command == "1")
                {
                    int speed = ChooseGameSpeed();
                    int difficulty = ChooseGameDifficulty();

                    //NYI
                    //PlayGame(speed, difficulty);
                }
                else if (command == "highscore" || command == "2")
                {
                    //NYI
                    //PrintHighscore();
                }
                else if (command == "quit" || command == "3")
                {
                    Console.WriteLine("Have a nice day!");
                    continueMenu = false;
                }
                else
                    Console.WriteLine("Unknown command!");

            }
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1.Play");
            Console.WriteLine("2.Highscore");
            Console.WriteLine("3.Quit\n");
        }
        private static void PrintPauseMenu()
        {
            Console.WriteLine("\nPause Menu");
            Console.WriteLine("1.Börja om spelet");
            Console.WriteLine("2.Fortsätta spelet");
            Console.WriteLine("3.Avsluta spelet\n");
        }

        private static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }

        private static int ChooseGameSpeed() 
        {
            int speed = -1;
            string userInput;
            bool isValidChoice = false;
            
            Console.WriteLine("\nChoose game speed:");
            Console.WriteLine("1.Slow");
            Console.WriteLine("2.Normal");
            Console.WriteLine("3.Fast\n");

            while (!isValidChoice)
            {
                userInput = GetUserInput("Choice: ");

                if (userInput == "slow" || userInput == "1")
                {
                    speed = 1;
                    isValidChoice = true;
                    Console.WriteLine("Slow");
                }
                else if (userInput == "normal" || userInput == "2")
                {
                    speed = 2;
                    isValidChoice = true;
                    Console.WriteLine("Normal");
                }
                else if (userInput == "fast" || userInput == "3")
                {
                    speed = 3;
                    Console.WriteLine("Fast");
                    isValidChoice = true;
                }
                else
                    Console.WriteLine("Not a valid choice!");

            }
            return speed;
        }

        private static int ChooseGameDifficulty()
        {
            int difficulty = -1;
            string userInput;
            bool isValidChoice = false;

            Console.WriteLine("\nChoose difficulty:");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Hard\n");

            while (!isValidChoice)
            {
                userInput = GetUserInput("Choice: ");

                if (userInput == "easy" || userInput == "1")
                {
                    difficulty = 1;
                    isValidChoice = true;
                    Console.WriteLine("Easy");
                }
                else if (userInput == "medium" || userInput == "2")
                {
                    difficulty = 2;
                    isValidChoice = true;
                    Console.WriteLine("Medium");
                }
                else if (userInput == "hard" || userInput == "3")
                {
                    difficulty = 3;
                    Console.WriteLine("Hard");
                    isValidChoice = true;
                }
                else
                    Console.WriteLine("Not a valid choice!");
            }
            return difficulty;
        }
    }
}