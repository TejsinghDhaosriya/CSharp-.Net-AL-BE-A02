using System;
using System.Linq;
using LengthClassLibrary.exceptions;

namespace LengthClassLibrary
{
    public static class Currency
    {
        public static string ToCurrency(this LengthHelper lengthHelper,string value)
        {
            if (value.Any(char.IsDigit))
                 throw new InvalidCurrencyException(value);
            return "$"+value;
        }
    }
/*
    Extend the string class, add a new function called ToCurrency(). 
if string contains numbers,
the function will prepend $ sign to and return a new string or else 
it will throw an exception.*/
}
