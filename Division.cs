using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Division
    {
        public static void PerformDivision()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: ");
                int denominator = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {numerator / denominator}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}
