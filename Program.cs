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
            string commandArr;

            while (continueMenu)
            {
                PrintMainMenu();

                commandArr = GetUserInput();

                if (commandArr == "play" || commandArr == "1")
                {
                    //NYI
                    //PlayGame();
                    Console.WriteLine("Play");
                }
                else if (commandArr == "highscore" || commandArr == "2")
                {
                    //NYI
                    //PrintHighscore();
                    Console.WriteLine("Highscore");
                }
                else if (commandArr == "quit" || commandArr == "3")
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
            string commandArr = Console.ReadLine();
            return commandArr;
        }


    }
}