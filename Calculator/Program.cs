namespace Calculator
{
    internal class Program
    {
       static List<string> games = new();
        
       static void Main(string[] args)
        {
            Menu();
            
        }
       static void Menu()
        {
            var gameOn = true;
            do
            {
                Console.WriteLine("Welcome to the MathGame, please type your name:");
                var name = Console.ReadLine();
                var date = DateTime.Now;
                Console.Clear();

                Console.WriteLine($"Hello {name}, It's {date}. Please select the option you want to play:\n");
                Console.WriteLine("1- Addition");
                Console.WriteLine("2- Subtration");
                Console.WriteLine("3- Multiplication");
                Console.WriteLine("4- Division");
                Console.WriteLine("5- View historic");
                Console.WriteLine("6- Quit the game");
                var gameSelected = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (gameSelected)
                {
                    case 1:
                        MathOperations.Addition(); break;
                         

                    case 2:
                        MathOperations.Subtraction(); break;

                    case 3:
                        MathOperations.Multiplication(); break;

                    case 4:
                        MathOperations.Division(); break;

                    case 5:
                        GetGames(); break;
                    case 6:
                        gameOn = false;
                        Environment.Exit(1); break;
                                     

                    default: Console.WriteLine("Invalid Option"); break;

                }
            } while (gameOn);
            
            
        }
       static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History:");
            foreach (var game in games)
            {
                Console.WriteLine(game);
                Console.WriteLine("Press any key to go back to the game");
                Console.ReadLine();
            }
        }
        
        internal static void AddGame(string game)
        {
            games.Add(game);
        }
    }
        
}
