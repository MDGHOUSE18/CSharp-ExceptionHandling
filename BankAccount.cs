using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class BankAccount
    {
        public static void Withdraw()
        {
            double balance = 1000;
            try
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                    throw new InsufficientFundsException("Insufficient funds.");
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {balance}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
