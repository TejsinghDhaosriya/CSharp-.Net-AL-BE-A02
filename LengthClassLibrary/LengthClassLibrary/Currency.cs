using System;
using System.Linq;
using LengthClassLibrary.exceptions;

namespace LengthClassLibrary
{
    public static class Currency
    {
        public static string ToCurrency(this LengthHelper lengthHelper,string value)
        {
            if(null == value)
                throw new InvalidCurrencyException("No Currency Passed");
            if (value.Any(char.IsDigit))
                 throw new InvalidCurrencyException("Invalid Currency Passed: "+value);
            return "$"+value;
        }
    }
}
