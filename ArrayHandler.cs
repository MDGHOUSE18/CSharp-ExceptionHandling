using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class ArrayHandler
    {
        public void AccessElement()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            try
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Value: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
