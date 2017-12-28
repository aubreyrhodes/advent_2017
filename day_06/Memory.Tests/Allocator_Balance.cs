using System;
using Xunit;

namespace Memory.Tests
{
    public class Allocator_Balance
    {
        private readonly Allocator _service;

        public Allocator_Balance()
        {
            _service = new Allocator();
        }

        [Fact]
        public void TestOne()
        {
            var result = _service.RoundsToBalance(new int[] { 0, 2, 7, 0 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestTwo()
        {
            var result = _service.RoundsInLoop(new int[] { 0, 2, 7, 0 });
            Assert.Equal(4, result);
        }
    }
}