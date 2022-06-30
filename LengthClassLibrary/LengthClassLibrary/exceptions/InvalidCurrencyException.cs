using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthClassLibrary.exceptions
{
    public class InvalidCurrencyException:ApplicationException
    {
        public InvalidCurrencyException() { }

        public InvalidCurrencyException(string name)
            : base($"Invalid Currency Passed: {name}")
        {

        }
    }
}
