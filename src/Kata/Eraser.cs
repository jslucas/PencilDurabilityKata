using System;

namespace Kata
{
    public class Eraser : Durable
    {
        private Pencil mPencil;
        internal Pencil Pencil { get { return mPencil; } }


        internal Eraser() { }

        internal Eraser(Pencil pencil) : this(pencil, 0) { }

        internal Eraser(Pencil pencil, int durability)
        {
            this.mPencil = pencil;
            this.mInitialDurability = durability;
            this.Durability = durability;
        }


        internal string Erase(string text, string textToErase)
        {
            int i = text.LastIndexOf(textToErase);
            return text.Remove(i, textToErase.Length).Insert(i, new String(' ', textToErase.Length));
        }



    }
}