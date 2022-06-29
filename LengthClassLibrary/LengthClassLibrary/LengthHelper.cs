using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthClassLibrary
{
    public class LengthHelper
    {
        public int findLength(string data)
        {
            return data?.Length ?? 0;
        }
    }
}
