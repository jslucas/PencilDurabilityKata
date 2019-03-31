using System;


namespace Kata
{
    public abstract class Durable
    {
        protected int mInitialDurability;
        public int Durability { get; set; }


        public void LowerDurability(int cost)
        {
            this.Durability = Math.Max(0, this.Durability - cost);
        }


    }
}