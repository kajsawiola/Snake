namespace SnakeTheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake!");
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
                    Console.WriteLine("Play");
                }
                else if (command == "highscore" || command == "2")
                {
                    //NYI
                    //PrintHighscore();
                    Console.WriteLine("Highscore");
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

        private static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string command = Console.ReadLine();
            return command;
        }

        private static int ChooseGameSpeed() 
        {
            int speed = -1;
            string speedChoice;
            bool isValidChoice = false;
            
            Console.WriteLine("\nChoose game speed:");
            Console.WriteLine("1.Slow");
            Console.WriteLine("2.Normal");
            Console.WriteLine("3.Fast\n");

            while (!isValidChoice)
            {
                speedChoice = GetUserInput("Choice: ");

                if (speedChoice == "slow" || speedChoice == "1")
                {
                    speed = 1;
                    isValidChoice = true;
                    Console.WriteLine("Slow");
                }
                else if (speedChoice == "normal" || speedChoice == "2")
                {
                    speed = 2;
                    isValidChoice = true;
                    Console.WriteLine("Normal");
                }
                else if (speedChoice == "fast" || speedChoice == "3")
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
            string speedChoice;
            bool isValidChoice = false;

            Console.WriteLine("\nChoose difficulty:");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Hard\n");

            while (!isValidChoice)
            {
                speedChoice = GetUserInput("Choice: ");

                if (speedChoice == "easy" || speedChoice == "1")
                {
                    difficulty = 1;
                    isValidChoice = true;
                    Console.WriteLine("Easy");
                }
                else if (speedChoice == "medium" || speedChoice == "2")
                {
                    difficulty = 2;
                    isValidChoice = true;
                    Console.WriteLine("Medium");
                }
                else if (speedChoice == "hard" || speedChoice == "3")
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