using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public static class StringExtensions
    {
        public static int DurabilityCost(this string text)
        {
            IEnumerable<char> nonWhitespaceChars = text.ToCharArray().Where(c => !Char.IsWhiteSpace(c));
            int numOfUpperCaseChars = nonWhitespaceChars.Where(c => Char.IsUpper(c)).Count();
            int numOfLowerCaseChars = nonWhitespaceChars.Count() - numOfUpperCaseChars;

            return numOfLowerCaseChars + (numOfUpperCaseChars * 2);
        }


    }
}