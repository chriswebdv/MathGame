using System.Reflection.Metadata.Ecma335;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create menu to choose math operator
            Console.WriteLine("Welcome to the Math Game!");
            
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
                if (choice == "add")
                {
                    Console.WriteLine($"Your result is {num1 + num2}");
                }
            }
            Console.WriteLine("Got out of the loop");

            // Record previous games inside a list to access them

        }

    }   
        
}
