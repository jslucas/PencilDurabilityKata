using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Pencil : Durable
    {
        #region "Props"
        public string Text { get; set; }
        public int Length { get; private set; }
        public Eraser Eraser { get; private set; }

        #endregion


        #region "Ctors"
        public Pencil() : this(0, 0) { }


        public Pencil(int durability) : this(durability, 0) { }


        public Pencil(int durability, int length) : this(durability, length, 0)
        {

        }

        public Pencil(int durability, int length, int eraserDurability)
        {
            this.Eraser = new Eraser(this, eraserDurability);
            this.Length = length;
            this.mInitialDurability = durability;
            this.Durability = durability;
        }


        #endregion


        #region "Methods"
        public string Write(string text)
        {
            int durabilityCost = text.DurabilityCost();
            if (this.Durability < durabilityCost)
            {
                text = this.DullWrite(text);
            }

            this.LowerDurability(durabilityCost);
            this.Text += text;

            return this.Text;
        }


        public void Sharpen()
        {
            this.Durability = mInitialDurability;
            this.Length = Math.Max(0, this.Length - 1);
        }


        public string DullWrite(string input)
        {
            int cost = 0;
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i])) { cost += 2; }
                else if (Char.IsLower(input[i])) { cost += 1; }

                if (cost > this.Durability)
                {
                    int remainder = input.Length - i;
                    result = input.Remove(i, remainder).Insert(i, new String(' ', remainder));
                    break;
                }
            }

            return result;
        }


        public string Erase(string textToRemove)
        {
            this.Text = this.Eraser.Erase(this.Text, textToRemove);
            return this.Text;
        }


        #endregion


    }
}