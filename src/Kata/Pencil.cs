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

            this.Durability -= text.Length;

            if (this.Durability < 1)
            {
                text = new String(' ', text.Length);
            }

            this.Text += text;

            return this.Text;
        }

    }

}