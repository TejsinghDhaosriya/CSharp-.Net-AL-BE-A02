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
}
