using System;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; private set; }
        public int Durability { get; private set; }

        public Pencil() { }
        public Pencil(int durability)
        {
            this.Durability = durability;
        }

        public string Write(string input)
        {
            this.Text += input;

            return this.Text;
        }

    }

}