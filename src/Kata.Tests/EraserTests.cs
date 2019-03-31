using System;
using Xunit;

namespace Kata.Tests
{
    public class EraserTests
    {
        [Fact]
        public void EraserRemovesLastOccuranceOfText()
        {
            var pencil = new Pencil(6, 1);
            pencil.Write("Lorem");
            Assert.Equal("   em", pencil.Erase("Lor"));
        }


    }
}