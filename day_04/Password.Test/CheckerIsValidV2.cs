using System;
using Xunit;

namespace Password.Test
{
    public class Checker_IsValidV2
    {
        private readonly Checker _service;

        public Checker_IsValidV2()
        {
            _service = new Checker();
        }

        [Fact]
        public void TestValid()
        {
            var result = _service.IsValidV2("abcde fghij");
            Assert.True(result);
        }

        [Fact]
        public void TestInvalid()
        {
            var result = _service.IsValidV2("abcde xyz ecdab");
            Assert.False(result);
        }
    }
}