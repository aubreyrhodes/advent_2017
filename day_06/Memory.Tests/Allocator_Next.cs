using System;
using Xunit;

namespace Memory.Tests
{
    public class Allocator_Next
    {
        private readonly Allocator _service;

        public Allocator_Next()
        {
            _service = new Allocator();
        }

        [Fact]
        public void TestOne()
        {
            var result = _service.Next(new int[] { 0, 2, 7, 0 });
            Assert.Equal(new int[] { 2, 4, 1, 2 }, result);
        }
    }
}
