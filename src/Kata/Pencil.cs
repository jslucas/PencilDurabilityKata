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
            this.Durability -= input.Length;

            this.Text += input;

            return this.Text;
        }

    }

}