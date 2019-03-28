using System;
using Xunit;

namespace Kata.Tests
{
    public class Tests
    {
        [Fact]
        public void WhenWriteIsPassedAStringItShouldAppearOnPaper()
        {
            Pencil pencil = new Pencil();
            Assert.Equal("lorem ipsum", pencil.Write("lorem ipsum"));
        }

    }
}