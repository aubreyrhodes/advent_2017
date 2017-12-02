using System;
using Xunit;

namespace RunSum.Tests
{
    public class RunSumService_GetSum
    {
        private readonly RunSumService _runSumService;

        public RunSumService_GetSum()
        {
            _runSumService = new RunSumService();
        }

        [Fact]
        public void FirstCase()
        {
            var sum = _runSumService.GetSum("1122");
            Assert.Equal(3, sum);
        }

        [Fact]
        public void SecondCase()
        {
            var sum = _runSumService.GetSum("1111");
            Assert.Equal(4, sum);
        }

        [Fact]
        public void ThirdCase()
        {
            var sum = _runSumService.GetSum("1234");
            Assert.Equal(0, sum);
        }

        [Fact]
        public void ForthCase()
        {
            var sum = _runSumService.GetSum("91212129");
            Assert.Equal(9, sum);
        }
    }
}
