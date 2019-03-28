using System;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; private set; }
        public int Durability { get; private set; } = 0;

        public Pencil() { }
        public Pencil(int durability)
        {
            this.Durability = durability;
        }

        public string Write(string input)
        {
            string text = input;

            if (this.Durability < text.Length)
            {
                text = this.DullWrite(text);
            }

            this.Dull(text.Length);

            this.Text += text;

            return this.Text;
        }

        private void Dull(int numOfChars)
        {
            this.Durability -= numOfChars;
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