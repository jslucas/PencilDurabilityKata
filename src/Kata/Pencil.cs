using System;
using System.Linq;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; private set; }
        public int Durability { get; set; } = 0;

        public Pencil() { }
        public Pencil(int durability)
        {
            this.Durability = durability;
        }

        public string Write(string text)
        {
            int numOfNonWhitespaceChars = text.Count(c => !Char.IsWhiteSpace(c));

            if (this.Durability < numOfNonWhitespaceChars)
            {
                text = this.DullWrite(text);
            }

            this.Dull(numOfNonWhitespaceChars);

            this.Text += text;

            return this.Text;
        }

        private void Dull(int numOfChars)
        {
            this.Durability = Math.Max(0, this.Durability - numOfChars);
        }

        // TODO: Change to extension method?
        private string DullWrite(string input)
        {
            int difference = input.Length - this.Durability;
            string whiteSpace = new String(' ', difference);

            return input.Remove(this.Durability, difference).Insert(this.Durability, whiteSpace);
        }

    }

}