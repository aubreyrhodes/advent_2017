using System;
using Xunit;

namespace Checksum.Tests
{
    public class Checksum_GetSum
    {
        private readonly ChecksumService _service;

        public Checksum_GetSum()
        {
            _service = new ChecksumService();
        }

        [Fact]
        public void TestOne()
        {
            var result = _service.GetSum("5 1 9 5\n7 5 3\n2 4 6 8\n");
            Assert.Equal(18, result);
        }
    }
}
