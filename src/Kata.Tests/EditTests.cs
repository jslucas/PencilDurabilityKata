using System;
using Xunit;


namespace Kata.Tests
{
    public class EditTests
    {
        [Fact]
        public void EditsInsertTextIntoWhitespaceFromLastDelete()
        {
            var pencil = new Pencil(50, 1, 50);
            pencil.Write("Lorem ipsum dolor sit amet");
            pencil.Erase("ipsum");
            Assert.Equal("Lorem quinc dolor sit amet", pencil.Edit("quinc"));
        }


    }
}