using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace SnakeTheGame
{
    class Snake
        // star test
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
        public List<Obstacle> Obstacles { get; }
        public List<Fruit> FruitList { get; }
        public Level(int width, int height, List<Obstacle> obstacles, List<Fruit> fruitList)
        {
            Width = width;
            Height = height;
            Obstacles = obstacles;
            FruitList = fruitList;
        }
        public void DrawLevel() // Ritar ut level
        {
            Console.WriteLine(new String('-', Width + 2)); // Ritar översta raden

            for (int i = 0; i < Height; i++) // Ritar mellanslag med | på varsin sida
            {
                Console.Write('|');
                Console.Write(new String(' ', Width));
                
                Random random = new Random();   
                foreach (Fruit f in FruitList) 
                {
                    
                    {
                        f.X = random.Next(1, Console.WindowWidth - 1);
                        f.Y = random.Next(1, Console.WindowHeight - 1);
                        Console.SetCursorPosition(f.X + 1, i + 1);
                        Console.ForegroundColor = f.Color;
                        Console.Write(f.Symbol);
                    }
                }

                Console.WriteLine('|');
            }
            Console.WriteLine(new String('-', Width + 2)); // Ritar nedersta raden
        }
        public static Level EasyLevel()
        {
            Random random = new Random();
            List<Fruit> fruits = new List<Fruit>
    {
        new Fruit(0, 0, ConsoleColor.Red, '*', 1),
        new Fruit(0, 0, ConsoleColor.Yellow, 'C', 2),
        new Fruit(0, 0, ConsoleColor.Green, 'O', 3)
    };

            List<Obstacle> obstacles = new List<Obstacle>
    {
        new Obstacle('-'),
        new Obstacle('|')
    };

            foreach (Fruit f in fruits)
            {
                f.X = random.Next(1, 60);
                f.Y = random.Next(1, 30);
            }

            return new Level(60, 30, obstacles, fruits);
        }
        /*public static Level EasyLevel()
        {
            return new Level(60, 30, new List<Obstacle>, new List<Fruit>)
            {
                new Obstacle('-'),
                new Obstacle('|'), 
                new Fruit('*'),

            });
        }*/
        public static Level MediumLevel()
        {
            Random random = new Random();
            List<Fruit> fruits = new List<Fruit>
    {
        new Fruit(0, 0, ConsoleColor.Red, '*', 1),
        new Fruit(0, 0, ConsoleColor.Yellow, 'C', 2),
        new Fruit(0, 0, ConsoleColor.Green, 'O', 3)
    };

            List<Obstacle> obstacles = new List<Obstacle>
    {
        new Obstacle('-'),
        new Obstacle('|')
    };

            foreach (Fruit f in fruits)
            {
                f.X = random.Next(1, 60);
                f.Y = random.Next(1, 30);
            }

            return new Level(60, 30, obstacles, fruits);
        }
        /*{
        return new Level(40, 20, new List<Obstacle>
        { 
            new Obstacle('-'),
            new Obstacle('|')
            // NYI: "new Obstacle(ormens 'char')" Vilket ska göra att det blir game over om man kör in i sig själv
        });
    }*/
        public static Level HardLevel()
        {
            Random random = new Random();
            List<Fruit> fruits = new List<Fruit>
    {
        new Fruit(0, 0, ConsoleColor.Red, '*', 1),
        new Fruit(0, 0, ConsoleColor.Yellow, 'C', 2),
        new Fruit(0, 0, ConsoleColor.Green, 'O', 3)
    };

            List<Obstacle> obstacles = new List<Obstacle>
    {
        new Obstacle('-'),
        new Obstacle('|')
    };

            foreach (Fruit f in fruits)
            {
                f.X = random.Next(1, 60);
                f.Y = random.Next(1, 30);
            }

            return new Level(60, 30, obstacles, fruits);
        }
        /* {
        return new Level(30, 10, new List<Obstacle>
        {
            new Obstacle('-'),
            new Obstacle('|')
        });
    }*/
    }
    class Obstacle
    {
        public char Symbol { get; }
        public Obstacle(char symbol) 
        {
            Symbol = symbol;
        }
    }
    /// <summary>
    /// Symbol för vilken char som är ett hinder
    /// </summary>
   

    class Fruit
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; } 
        public char Symbol { get; set; }
        public int Points { get; set; }

        public Fruit (int x, int y, ConsoleColor color, char symbol, int points)
        {
            X = x;
            Y = y;
            Color = color;
            Symbol = symbol;
            Points = points;
        }
    }

    
    class Godis
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public char Symbol { get; set; }
        public int Points { get; set; }

        public Godis(int x, int y, ConsoleColor color, char symbol, int points)
        {
            X = x;
            Y = y;
            Color = color;
            Symbol = symbol;
            Points = points;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake!");
            // Spela spelet från nivå 1 här..

            
            MainMenu();
        }

        private static void DrawFruit() 
        {
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Fruit(0, 0, ConsoleColor.Red, '*', 1));
            fruits.Add(new Fruit(0, 0, ConsoleColor.Yellow, 'C', 2));
            fruits.Add(new Fruit(0, 0, ConsoleColor.Green, 'O', 3));

            Random random = new Random();
            foreach (Fruit f in fruits)
            {
                f.X = random.Next(1, Console.WindowWidth - 1);
                f.Y = random.Next(1, Console.WindowHeight - 1);
                Console.WriteLine(f.Symbol);
            }
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

        private static bool PauseMenu()
        {   
            bool isGameOver = false;
            bool continuePauseMenu = true;
            string command;

            while (continuePauseMenu)
            {
                PrintPauseMenu();
                command = GetUserInput("Menu choice: ");

                if (command == "Play from start" || command == "1")
                {
                    
                    continuePauseMenu = false;
                    isGameOver = true;
                }

                else if (command == "Continue game" || command == "2")
                {
                    //NYI: fortsätter spelet där man pausade
                    continuePauseMenu = false;
                    isGameOver = false;
                }
                else if (command == "Quit game" || command == "3")
                {
                    bool continueYesNoOption = true;
                    while (continueYesNoOption)
                    {
                        Console.WriteLine("Are you sure you want to quit to main menu? Progress will be lost. ");
                        command = GetUserInput("Type 'yes' or 'no': ");
                        
                            if (command == "yes")
                            {
                            MainMenu();
                            continueYesNoOption = false;
                            continuePauseMenu = false;
                            isGameOver = false;

                            }
                            else if (command == "no")
                            {
                                Console.WriteLine("Returning to pause menu.");
                                continueYesNoOption = false;
                            }
                            else
                                Console.WriteLine("Unknown command!");                       
                    }
                }
                else 
                    Console.WriteLine("Unknown command!");
            }
            return isGameOver;
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
            bool isGameOver = false;


            //NYI: Set game speed and difficulty here
            //NYI: LoadLevel() or InitLevel()
            if (speed == 1 && difficulty == 1)
            {
                Level easy = Level.EasyLevel();
                easy.DrawLevel();
                
            }
            if (speed == 2 && difficulty == 2)
            {
                Level medium = Level.MediumLevel();
                medium.DrawLevel();
            }
            if (speed == 3 && difficulty == 3)
            {
                Level Hard = Level.HardLevel();
                Hard.DrawLevel();
            }
            //NYI Start a timer
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!isGameOver)
            {
                // Check if 500 milliseconds have passed
                if (stopwatch.ElapsedMilliseconds >= 500)
                {
                    Console.WriteLine("500 milliseconds have passed");
                    //UpdateLevel(); / DrawLevel();

                    stopwatch.Restart();
                }

                if (Console.KeyAvailable)
                {
                    var keyPressed = Console.ReadKey(true);

                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        //NYI: keyPressed LeftArrow
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                        Console.WriteLine("LeftArrow");
                    }

                    else if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        //NYI: keyPressed RightArrow
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                        Console.WriteLine("RightArrow");
                    }

                    else if (keyPressed.Key == ConsoleKey.UpArrow)
                    {
                        //NYI: keyPressed UpArrow
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                        Console.WriteLine("UpArrow");
                    }

                    else if (keyPressed.Key == ConsoleKey.DownArrow)
                    {
                        //NYI: keyPressed DownArrow
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                        Console.WriteLine("DownArrow");
                    }

                    else if (keyPressed.Key == ConsoleKey.Escape || keyPressed.Key == ConsoleKey.Spacebar)
                    {
                        stopwatch.Stop();
                        
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                        Console.WriteLine("Paus");
                        isGameOver = PauseMenu(); //Return value från pause menu beror på om man valt att fortsätta spelet eller inte.
                        stopwatch.Restart(); // Få in denna under continue i metoden PauseMenu ?? 

                    }


                }


            }


            
            
        }

    }
}