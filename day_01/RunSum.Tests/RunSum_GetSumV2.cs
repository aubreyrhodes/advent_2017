using System;
using Xunit;

namespace RunSum.Tests
{
    public class RunSum_GetSumV2
    {
        private readonly RunSumService _service;

        public RunSum_GetSumV2()
        {
            _service = new RunSumService();
        }

        [Fact]
        public void TestOne()
        {
            var result = _service.GetSumV2("1212");
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestTwo()
        {
            var result = _service.GetSumV2("1221");
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestThree()
        {
            var result = _service.GetSumV2("123425");
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestFour()
        {
            var result = _service.GetSumV2("123123");
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestFive()
        {
            var result = _service.GetSumV2("12131415");
            Assert.Equal(4, result);
        }
    }
}