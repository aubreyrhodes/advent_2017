using System;
using Xunit;

namespace Checksum.Tests
{
    public class Checksum_GetSumV2
    {
        private readonly ChecksumService _service;

        public Checksum_GetSumV2()
        {
            _service = new ChecksumService();
        }

        [Fact]
        public void TestV2()
        {
            var result = _service.GetSumV2("5 9 2 8\n9 4 7 3\n3 8 6 5\n");
            Assert.Equal(9, result);
        }
    }
}