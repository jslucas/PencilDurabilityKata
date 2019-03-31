using System;
using Xunit;

namespace Kata.Tests
{
    public class EraserTests
    {
        #region "Test context"
        private Pencil pencil;

        public EraserTests()
        {
            this.pencil = new Pencil(6, 1, 4);
        }


        #endregion


        [Fact]
        public void EraserRemovesLastOccuranceOfText()
        {
            var pencil = new Pencil(6, 1);
            pencil.Write("Lorem");
            Assert.Equal("   em", pencil.Erase("Lor"));
        }


        [Fact]
        public void WhenAnEraserIsCreatedItCanBeGivenADurabilityValue()
        {
            Assert.Equal(4, this.pencil.Eraser.Durability);
        }


    }
}