using System;
using Xunit;

namespace Password.Test
{
    public class Checker_IsValid
    {
        private readonly Checker _service;

        public Checker_IsValid()
        {
            _service = new Checker();
        }

        [Fact]
        public void TestInvalid1()
        {
            var result = _service.IsValid("aa bb cc dd aa");
            Assert.False(result);
        }

        [Fact]
        public void TestValid()
        {

            var result = _service.IsValid("aa bb cc dd ee");
            Assert.True(result);
        }
    }
}
