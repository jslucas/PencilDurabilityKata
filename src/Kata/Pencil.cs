using System;

namespace Kata
{
    public class Pencil
    {
        public string Text { get; private set; }

        public string Write(string input)
        {
            this.Text += input;

            return this.Text;
        }

    }

}