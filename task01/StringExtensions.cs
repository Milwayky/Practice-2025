using System;
using System.Collections.Generic;

namespace task01
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            string str = input.ToLower();
            List<char> list = new List<char>();
            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                {
                    list.Add(c);
                }
            }
            string cleaned = new string(list.ToArray());
            list.Reverse();
            string reversed = new string(list.ToArray());
            return cleaned == reversed;
        }
    }
}