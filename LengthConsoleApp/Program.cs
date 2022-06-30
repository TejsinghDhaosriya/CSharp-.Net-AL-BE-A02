using System;
using LengthClassLibrary;
using LengthClassLibrary.exceptions;

namespace LengthConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter string whose length is to be calculated: ");
            var data = Console.ReadLine();

            var lh = new LengthHelper();
            var length = lh.findLength(data);

            Console.WriteLine("Length is :"+ length);
           

            //Assignment 4
            try {
                var currency = lh.ToCurrency(data);
                Console.WriteLine("Currency is: " + currency);
            }
            catch (InvalidCurrencyException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}