using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; set; }
        private int initialDurability;
        public int Durability { get; set; }
        public int Length { get; private set; }


        public Pencil() : this(0, 0) { }


        public Pencil(int durability) : this(durability, 0) { }


        public Pencil(int durability, int length)
        {
            this.Length = length;
            this.initialDurability = durability;
            this.Durability = durability;
        }


        public string Write(string text)
        {
            int durabilityCost = text.DurabilityCost();
            if (this.Durability < durabilityCost)
            {
                text = this.DullWrite(text);
            }

            this.Dull(durabilityCost);
            this.Text += text;

            return this.Text;
        }


        public void Sharpen()
        {
            this.Durability = initialDurability;
        }


        public void Dull(int numOfChars)
        {
            this.Durability = Math.Max(0, this.Durability - numOfChars);
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


    }
}