using System;
using LengthClassLibrary;

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
            Console.Read();
        }
    }
}