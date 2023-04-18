﻿using System;
using System.Collections.Generic;
namespace SnakeTheGame
{
    class Snake
    {
        int positionX, positionY, length, direction;

        public Snake(int x, int y, int length, int direction)
        {
            this.positionX = x;
            this.positionY = y;
            this.length = length;
            this.direction = direction;
        }

        public void MoveSnake()
        {

        }
        public void AddToSnake(int points)
        {
            this.length += points;
        }
        public bool DetectCollision()
        {
            return false;
        }

        public void DrawSnake()
        {

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
        public static Level EasyLevel()
        {
            return new Level(60, 30);
        }
        public static Level MediumLevel()
        {
            return new Level(40, 20);
        }
        public static Level HardLevel()
        {
            return new Level(30, 10);
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake!");
            Level easy = Level.EasyLevel();
            easy.DrawLevel();
            Level medium = Level.MediumLevel();
            medium.DrawLevel();
            Level hard = Level.HardLevel();
            hard.DrawLevel();
            // Spela spelet från nivå 1 här..
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

                    PlayGame(speed, difficulty);
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

        private static void PauseMenu()
        { bool continueMenu = true;
        string command;
            while (continueMenu)
            {
                PrintPauseMenu();
                command = GetUserInput("Menu choice: ");

                if (command == "Play from start" || command == "1")
                {
                    MainMenu();
                    continueMenu = false;
                }

                else if (command == "Continue game" || command == "2")
                {
                    //NYI: fortsätter spelet där man pausade
                }
                else if (command == "Quit game" || command == "3")
                {

                    while (continueMenu)
                    {
                        Console.WriteLine("The game is over, do you want to start a new one? ");
                        command = GetUserInput("Type 'yes' or 'no': ");
                        
                            if (command == "yes")
                            {
                                MainMenu();
                                continueMenu = false;
                            }
                            else if (command == "no")
                            {
                                Console.WriteLine("Have a nice day!");
                                continueMenu = false;
                            }
                            else
                                Console.WriteLine("Unknown command!");                       
                    }
                }
                else Console.WriteLine("Unknown command!");
            }
        }
        private static void PrintPauseMenu()
        {
            Console.WriteLine("\nPause Menu");
            Console.WriteLine("1.Play from start");
            Console.WriteLine("2.Continue game");
            Console.WriteLine("3.Quit\n");
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

        private static void PlayGame(int speed, int difficulty)
        {   
            //NYI: Set game speed and difficulty here
            //NYI: LoadLevel() or InitLevel()

            if (Console.KeyAvailable)
            {
                var keyPressed = Console.ReadKey(true);

                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    //NYI: keyPressed LeftArrow
                }

                else if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    //NYI: keyPressed RightArrow
                }

                else if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    //NYI: keyPressed UpArrow
                }

                else if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    //NYI: keyPressed DownArrow
                }

                else if (keyPressed.Key == ConsoleKey.Escape || keyPressed.Key == ConsoleKey.Spacebar)
                {
                    //NYI: keyPressed Escape or Spacebar
                }


            }
            
        }

    }
}