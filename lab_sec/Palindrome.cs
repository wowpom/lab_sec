using System;
using System.Collections.Generic;
using System.Text;

namespace lab_sec
{
    public static class Palindrome
    {
        public static bool IsPalindrome(this String number)
        {
            char[] digit = number.ToCharArray();
            switch (digit.Length)
            {
                case 1:
                    return false;
                case 2:
                    if (digit[0] == digit[1])
                        return true;
                    else
                        return false;
            }

            for(int i = 0; i <= digit.Length / 2; i++)
            {
                if (digit[i] != digit[digit.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
