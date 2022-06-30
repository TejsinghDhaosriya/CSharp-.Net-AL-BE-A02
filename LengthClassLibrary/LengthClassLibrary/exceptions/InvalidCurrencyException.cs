using System;

namespace LengthClassLibrary.exceptions
{
    public class InvalidCurrencyException:ApplicationException
    {
        
        public InvalidCurrencyException(string name)
            : base(name)
        { }
    }
}
