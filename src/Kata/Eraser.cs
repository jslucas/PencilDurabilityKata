using System;

namespace Kata
{
    public class Eraser
    {
        private Pencil pencil;
        private int initialDurability;
        public int Durability { get; set; }
        internal Pencil Pencil { get { return pencil; } }


        internal Eraser() { }

        internal Eraser(Pencil pencil) : this(pencil, 0) { }

        internal Eraser(Pencil pencil, int durability)
        {
            this.pencil = pencil;
            this.initialDurability = durability;
            this.Durability = durability;
        }


        internal string Erase(string text, string textToErase)
        {
            int i = text.LastIndexOf(textToErase);
            return text.Remove(i, textToErase.Length).Insert(i, new String(' ', textToErase.Length));
        }


    }
}