using System;
using Xunit;

namespace Kata.Tests
{
    public class WriteTests
    {
        private Pencil pencil;

        public WriteTests()
        {
            this.pencil = new Pencil(500);
        }

        [Fact]
        public void WhenWriteIsPassedAStringItShouldAppearOnPaper()
        {
            Assert.Equal("lorem ipsum", pencil.Write("lorem ipsum"));
        }

        [Fact]
        public void WriteAppendsStringToExistingTextOnPaper()
        {
            pencil.Write("lorem ipsum");
            Assert.Equal("lorem ipsum dolor sit amet", pencil.Write(" dolor sit amet"));
        }

    }
}