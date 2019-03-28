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

        [Fact]
        public void WriteAppendsStringToExistingTextOnPaper()
        {
            Pencil pencil = new Pencil();
            pencil.Write("lorem ipsum");
            Assert.Equal("lorem ipsum dolor sit amet", pencil.Write(" dolor sit amet"));
        }

        [Fact]
        public void WhenAPencilIsCreatedItCanBeGivenADurabilityValue()
        {
            Pencil pencil = new Pencil(5);
            Assert.Equal(5, pencil.Durability);
        }

    }
}