using System;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; set; }
        public int Durability { get; set; } = 0;

        public Pencil() { }

        public Pencil(int durability)
        {
            this.Durability = durability;
        }

    }

}