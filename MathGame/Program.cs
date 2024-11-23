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
            // Divisions must be int only, from 0 - 100 

            while (true)
            {
                Console.WriteLine("Please choose operator, add, subtract, multiple or divide");
                string choice = Console.ReadLine().ToLower();
                Console.WriteLine("First number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());


                if (choice == "")
                {
                    break;
                }
                if (choice != "add" || choice != "subtract" || choice != "multiply" || choice != "divide")
                {
                    continue;
                }
                else if (choice == "add")
                {
                    Console.WriteLine($"Your result is {num1 + num2}");
                }
                else if (choice == "subtract")
                {
                    Console.WriteLine($"Your result is {num1 - num2}");
                }
                else if (choice == "multiply")
                {
                    Console.WriteLine($"Your result is {num1 * num2}");
                }
                else
                {
                    if (choice == "divide")
                    {
                        if ((num1 >= 0 && num1 <= 100) && (num2 >= 0 && num2 <= 100))
                        {
                            if (num1 % num2 == 0)
                            {
                                Console.WriteLine($"Your result is {num1 / num2}");
                            }

                        }
                        else
                        {
                            continue;
                        }
                    } 
                }
            }
            Console.WriteLine("Got out of the loop");

            // Record previous games inside a list to access them

        }

    }   
        
}
