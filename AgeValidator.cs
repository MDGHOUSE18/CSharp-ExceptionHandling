using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class AgeValidator
    {
        public static void ValidateAge()
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 18)
                    throw new InvalidAgeException("Age must be 18 or above.");
                Console.WriteLine("Eligible.");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
        }

        public InvalidAgeException(string? message) : base(message)
        {
        }

        
    }
}
