using System;
using Xunit;

namespace Jumper.Tests
{
    public class List_MovesToJumpOut
    {
        [Fact]
        public void TestExample()
        {
            var list = new List(new int[] { 0, 3, 0, 1, -3 }, 0);
            var result = list.GetMovesToJumpOut();
            Assert.Equal(5, result);
        }
    }
}