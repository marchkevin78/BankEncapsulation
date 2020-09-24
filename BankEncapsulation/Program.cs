using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var kevinsAccount = new BankAccount();
           
            //Console.WriteLine("How much would you like to deposit?");

            //var amountToDeposit = double.Parse(Console.ReadLine());

            //account.Deposit(amountToDeposit);

            //Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");

            var kevinsInfo = new PersonalInformation();
            string number;
            long result;

            do
            {
                Console.WriteLine("What is your phone number starting with the area code?");
                Console.WriteLine("with the following format: 1234567890");
                number = Console.ReadLine();


            } while (number.Length != 10 || !long.TryParse(number, out result));

            kevinsInfo.FormattedNumber = number;
            Console.WriteLine(kevinsInfo.FormattedNumber);

            Console.WriteLine($"Your new phone number is {kevinsInfo.FormattedNumber}");
        }
    }
}
