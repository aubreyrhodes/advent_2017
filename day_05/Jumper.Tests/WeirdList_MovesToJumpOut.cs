using System;
using Xunit;

namespace Jumper.Tests
{
    public class WeirdList_MovesToJumpOut
    {
        [Fact]
        public void TestMovesToJumpOut()
        {
            var list = new WeirdList(new int[] { 0, 3, 0, 1, -3 }, 0);
            var result = list.GetMovesToJumpOut();
            Assert.Equal(10, result);
        }
    }
}