using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class MathOperations
    {
        public static void CalculateSquareRoot()
        {
            try
            {
                Console.Write("Enter number: ");
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                    throw new ArgumentException("Cannot calculate square root of a negative number.");
                Console.WriteLine($"Square root: {Math.Sqrt(number)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
