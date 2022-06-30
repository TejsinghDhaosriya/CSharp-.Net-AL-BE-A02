using System;

namespace LengthClassLibrary.exceptions
{
    public class InvalidCurrencyException:ApplicationException
    {
        
        public InvalidCurrencyException(string name)
            : base($"Invalid Currency Passed: {name}")
        { }
    }
}
