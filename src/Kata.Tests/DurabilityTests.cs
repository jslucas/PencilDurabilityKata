using System;
using Xunit;

namespace Kata.Tests
{
    public class DurabilityTests
    {
        #region "Test context"
        private Pencil pencil;

        public DurabilityTests()
        {
            this.pencil = new Pencil();
        }


        #endregion


        [Fact]
        public void WhenAPencilIsCreatedItCanBeGivenADurabilityValue()
        {
            Pencil pencil = new Pencil(5);
            Assert.Equal(5, pencil.Durability);
        }


        [Fact]
        public void APencilLosesDurabilityAfterWriting()
        {
            pencil.Durability = 5;
            pencil.Write("Lorem");
            Assert.Equal(0, pencil.Durability);
        }


        [Fact]
        public void APencilOnlyWritesWhitespaceWhenDull()
        {
            Assert.Equal("     ", pencil.Write("lorem"));
        }


        [Fact]
        public void WritingWhitespaceAndNewLinesDoesNotLowerPencilDurability()
        {
            pencil.Durability = 5;
            pencil.Write("     ");
            Assert.Equal(5, pencil.Durability);
        }


        [Fact]
        public void UpperCaseLettersLowerDurabilityByTwo()
        {
            pencil.Durability = 10;
            pencil.Write("Lorem");
            Assert.Equal(4, pencil.Durability);
        }


        [Fact]
        public void LowerCaseLettersLowerDurabilityByOne()
        {
            pencil.Durability = 10;
            pencil.Write("LoREm");
            Assert.Equal(2, pencil.Durability);
        }


        [Fact]
        public void PencilWillReplaceCharactersWithWhitespaceIfWordRequiresMoreDurabilityThanAvailable()
        {
            pencil.Durability = 15;
            // Assert.Equal("Lorem ipsum dolo          ", pencil.Write("Lorem ipsum dolor sit amet"));
            Assert.Equal("LOREM IP                  ", pencil.Write("LOREM IPSUM dolor sit amet"));
        }


    }
}