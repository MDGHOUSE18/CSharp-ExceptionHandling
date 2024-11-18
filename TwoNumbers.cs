using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class TwoNumbers
    {
        public static void ExTwoNumbers()
        {
            try
            {
                Console.Write("Input the first number: ");
                string input1 = Console.ReadLine();
                double number1 = Convert.ToDouble(input1);

                Console.Write("Input the second number: ");
                string input2 = Console.ReadLine();
                double number2 = Convert.ToDouble(input2);

                if (number2 != 0)
                {
                    double result = number1 / number2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
