using System;

namespace CreditCardCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardnum;
            Console.WriteLine("please insert your credit card mnumber");
            cardnum = Console.ReadLine();
            Convert.ToInt32(cardnum);

            //static bool luhn(string creditcardnum);

        }
    }
}
