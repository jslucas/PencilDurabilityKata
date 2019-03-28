using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public static class PencilService
    {
        public static string Write(this Pencil pencil, string text)
        {
            int durabilityCost = text.DurabilityCost();

            if (pencil.Durability < durabilityCost)
            {
                text = pencil.DullWrite(text);
            }

            pencil.Dull(durabilityCost);

            pencil.Text += text;

            return pencil.Text;
        }

        public static void Dull(this Pencil pencil, int numOfChars)
        {
            pencil.Durability = Math.Max(0, pencil.Durability - numOfChars);
        }

        public static string DullWrite(this Pencil pencil, string input)
        {
            int difference = input.Length - pencil.Durability;
            string whiteSpace = new String(' ', difference);

            return input.Remove(pencil.Durability, difference).Insert(pencil.Durability, whiteSpace);
        }

        public static int DurabilityCost(this string text)
        {
            var nonWhitespaceChars = text.ToCharArray()
                                         .Where(c => !Char.IsWhiteSpace(c));

            int numOfUpperCaseChars = nonWhitespaceChars.Where(c => Char.IsUpper(c)).Count();

            int numOfLowerCaseChars = nonWhitespaceChars.Count() - numOfUpperCaseChars;

            return numOfLowerCaseChars + (numOfUpperCaseChars * 2);

        }
    }
}