using System;
using Xunit;

namespace Kata.Tests
{
    public class DurabilityTests
    {
        [Fact]
        public void WhenAPencilIsCreatedItCanBeGivenADurabilityValue()
        {
            Pencil pencil = new Pencil(5);
            Assert.Equal(5, pencil.Durability);
        }

        [Fact]
        public void APencilLosesDurabilityAfterWriting()
        {
            Pencil pencil = new Pencil(5);
            pencil.Write("Lorem ipsum");
            Assert.Equal(4, pencil.Durability);
        }

    }

}