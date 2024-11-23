using System.Reflection.Metadata.Ecma335;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create menu to choose operation
            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("Please choose operator, add, subtract, multiple or divide");
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine(choice);



            // Create Math Game that uses the 4 basic math operators
            // Divisions must be int only, from 0 - 100 
            // Record previous games inside a list to access them

        }

    }   
        
}
