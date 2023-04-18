using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SnakeTheGame
{
    class Snake
    {
        int headPositionX, headPositionY, length, direction;

        List<Point> snake = new List<Point>();

        public Snake(int x, int y, int length, int direction)
        {
            this.headPositionX = x;
            this.headPositionY = y;
            this.length = length;
            this.direction = direction;
            // First snake
            for (int i = 0; i < this.length; i++)
            {
                snake.Add(new Point(this.headPositionX - i, this.headPositionY));
            }
        }

        public void MoveSnake()
        {
        }
        public void AddToSnake(int points)
        {
            for (int i = 0; i < points; i++) {
            }    
        }
        public bool DetectCollision()
        {
            return false;
        }

        public void DrawSnake(Level level)
        {
            foreach(Point point in snake)
            {
            }
        }
    }
    class Level
    {
        public int Width { get; }
        public int Height { get; }
        public Level(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void DrawLevel() // Ritar ut level
        {
            Console.WriteLine(new String('-', Width + 2)); // Ritar översta raden

            for (int i = 0; i < Height; i++) // Ritar mellanslag med | på varsin sida
            {
                Console.Write('|');
                Console.Write(new String(' ', Width));
                Console.WriteLine('|');
            }
            Console.WriteLine(new String('-', Width + 2)); // Ritar nedersta raden
        }


    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake!");
            Level Level1 = new Level(40, 20); // Skapar en ny level
            Level1.DrawLevel(); // Ritar ut level
            
            // Spela spelet från nivå 1 här..
            MainMenu();
        }

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