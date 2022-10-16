using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSamplesWebApplication
{
    public class PalindromeBool
    {
        public bool IsPalindromeBool(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                string xString = x.ToString();
                char[] charArray = xString.ToCharArray();
                Array.Reverse(charArray);
                if (xString == new string(charArray))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}