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

                command = GetUserInput();

                if (command == "play" || command == "1")
                {
                    //NYI
                    //PlayGame();
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

        private static string GetUserInput()
        {
            Console.Write("Command:>");
            string command = Console.ReadLine();
            return command;
        }


    }
}