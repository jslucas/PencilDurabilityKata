using System;
using System.Linq;

namespace Kata
{
    public class Eraser : Durable
    {
        #region "Props"
        private Pencil mPencil;
        internal Pencil Pencil { get { return mPencil; } }


        #endregion


        #region "Ctors"
        internal Eraser() { }

        internal Eraser(Pencil pencil) : this(pencil, 0) { }

        internal Eraser(Pencil pencil, int durability)
        {
            this.mPencil = pencil;
            this.mInitialDurability = durability;
            this.Durability = durability;
        }


        #endregion


        #region "Methods"    
        internal string Erase(string text, string textToErase)
        {
            int cost = textToErase.Length;
            if (this.Durability < cost)
            {
                textToErase = textToErase.Substring(cost - this.Durability);
            }

            this.LowerDurability(cost);
            int i = text.LastIndexOf(textToErase);
            this.mPencil.Paper.ErasedIndexes.Add(i);

            return text.Remove(i, textToErase.Length).Insert(i, new String(' ', textToErase.Length));
        }


        #endregion


    }
}