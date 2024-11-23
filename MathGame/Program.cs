using System.Reflection.Metadata.Ecma335;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Game!");

            // Create menu to choose math operator
            // Create Math Game that uses the 4 basic math operators
            // Divisions must be integers only, from 0 - 100 

            // Add the total games played
            int totalGames = 0;

            // Create list to keep track of the games played
            List<String> games = new List<String>();

            while (true)
            {
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine("PLEASE CHOOSE OPERATOR, ADD, SUBTRACT, MULTIPLY OR DIVIDE");
                Console.WriteLine("OR TYPE HISTORY TO CHECK PREVIOUS GAMES");
                Console.WriteLine("____________________________________________________________");
                string choice = Console.ReadLine().ToLower();

                if (choice == "")
                {
                    break;
                }
                // Record previous games inside a list to access them
                if (choice == "history")
                {
                    foreach (String game in games)
                    {
                        Console.WriteLine(game);
                    }
                    break;
                }

                Console.WriteLine("First number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (choice != "add" && choice != "subtract" && choice != "multiply" && choice != "divide")
                {
                    continue;
                }
                else if (choice == "add")
                {
                    Console.WriteLine($"Your result is {num1 + num2}");
                    games.Add($"{num1} + {num2} = {num1 + num2}");
                    totalGames++;
                }
                else if (choice == "subtract")
                {
                    Console.WriteLine($"Your result is {num1 - num2}");
                    games.Add($"{num1} - {num2} = {num1 - num2}");
                    totalGames--;
                }
                else if (choice == "multiply")
                {
                    Console.WriteLine($"Your result is {num1 * num2}");
                    games.Add($"{num1} * {num2} = {num1 * num2}");
                    totalGames++;
                }
                else
                {
                    if (choice == "divide")
                    {
                        if ((num1 >= 0 && num1 <= 100) && (num2 >= 0 && num2 <= 100))
                        {
                            if (num2 != 0 && num1 % num2 == 0)
                            {
                                Console.WriteLine($"Your result is {num1 / num2}");
                                games.Add($"{num1} / {num2} = {num1 / num2}");
                                totalGames++;
                            }

                        }
                        else
                        {
                            continue;
                        }
                    } 
                }
            }
            Console.WriteLine($"Your total games played are {totalGames}");

        }

    }   
        
}
