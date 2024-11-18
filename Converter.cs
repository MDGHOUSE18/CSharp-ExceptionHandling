using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Converter
    {
        public static void ConvertStringToInt()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too large or too small.");
            }
        }
    }
}
