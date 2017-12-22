using System;
using Xunit;

namespace Jumper.Tests
{
    public class List_Next
    {

        [Fact]
        public void TestZero()
        {
            var originalList = new List(new int[] { 0, 1 }, 0);
            var nextList = originalList.GetNext();
            Assert.Equal(new int[] { 1, 1 }, nextList.Instructions);
            Assert.Equal(0, nextList.Position);
        }

        [Fact]
        public void TestOne()
        {
            var originalList = new List(new int[] { 1, 1 }, 0);
            var nextList = originalList.GetNext();
            Assert.Equal(new int[] { 2, 1 }, nextList.Instructions);
            Assert.Equal(1, nextList.Position);
        }
    }
}
