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
            this.pencil = new Pencil(durability: 5);
        }


        #endregion


        [Fact]
        public void WhenAPencilIsCreatedItCanBeGivenADurabilityValue()
        {
            Assert.Equal(5, pencil.Durability);
        }


        [Fact]
        public void APencilLosesDurabilityAfterWriting()
        {
            pencil.Write("Lorem");
            Assert.Equal(0, pencil.Durability);
        }


        [Fact]
        public void APencilOnlyWritesWhitespaceWhenDull()
        {
            pencil = new Pencil(durability: 0);
            Assert.Equal("     ", pencil.Write("lorem"));
        }


        [Fact]
        public void WritingWhitespaceAndNewLinesDoesNotLowerPencilDurability()
        {
            pencil.Write("     ");
            Assert.Equal(5, pencil.Durability);
        }


        [Fact]
        public void UpperCaseLettersLowerDurabilityByTwo()
        {
            pencil.Write("Lor");
            Assert.Equal(1, pencil.Durability);
        }


        [Fact]
        public void LowerCaseLettersLowerDurabilityByOne()
        {
            pencil.Write("amet");
            Assert.Equal(1, pencil.Durability);
        }


        [Fact]
        public void PencilWillReplaceCharactersWithWhitespaceIfWordRequiresMoreDurabilityThanAvailable()
        {
            pencil = new Pencil(durability: 15);
            Assert.Equal("LOREM IP                  ", pencil.Write("LOREM IPSUM dolor sit amet"));
        }


    }
}