using System;

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
