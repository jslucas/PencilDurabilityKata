using System;

namespace Kata
{
    internal class Eraser
    {
        private Pencil pencil;
        internal Pencil Pencil
        {
            get { return pencil; }
        }


        internal Eraser() { }
        internal Eraser(Pencil pencil)
        {
            this.pencil = pencil;
        }


        internal string Erase(string text, string textToErase)
        {
            int i = text.LastIndexOf(textToErase);
            return text.Remove(i, textToErase.Length).Insert(i, new String(' ', textToErase.Length));
        }


    }
}