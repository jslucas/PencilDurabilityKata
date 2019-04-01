using System;
using Xunit;


namespace Kata.Tests
{
    public class EditTests
    {
        #region "Test context"
        private Pencil pencil;

        public EditTests()
        {
            this.pencil = new Pencil(50, 1, 50);
            pencil.Write("Lorem ipsum dolor sit amet");
            pencil.Erase("ipsum");
        }


        #endregion


        [Fact]
        public void EditsInsertTextIntoWhitespaceFromLastDelete()
        {
            Assert.Equal("Lorem quinc dolor sit amet", pencil.Edit("quinc"));
        }


        [Fact]
        public void EditsThatOverlapWithExistingCharsAreReplacedWithCollisionChars()
        {
            Assert.Equal("Lorem artich@@@or sit amet", pencil.Edit("artichoke"));
        }


    }
}