using System;
using System.Linq;

namespace Kata
{
    public static class PencilService
    {
        public static string Write(this Pencil pencil, string text)
        {
            int numOfNonWhitespaceChars = text.Count(c => !Char.IsWhiteSpace(c));

            if (pencil.Durability < numOfNonWhitespaceChars)
            {
                text = pencil.DullWrite(text);
            }

            pencil.Dull(numOfNonWhitespaceChars);

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
    }
}