using System;

namespace Part3
{
    public class Factorials
    {
        public static void Main()
        {
            String keepGoing = "y";
            
            while(keepGoing.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter an integer: ");
                int val = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial({val}) = {MathUtils.Factorial(val)}");
                Console.Write("Another factorial? (y/n) ");
                keepGoing = Console.ReadLine();
            }
        }
    }
}