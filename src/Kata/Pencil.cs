using System;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; set; }
        private int initialDurability;
        public int Durability { get; set; } = 0;

        public Pencil() { }


        public Pencil(int durability)
        {
            this.initialDurability = durability;
            this.Durability = durability;
        }


        public void Sharpen()
        {
            this.Durability = initialDurability;
        }


    }
}