using System;
using Xunit;

namespace Spiral.Tests
{
    public class AdditiveSpiral_GetValueForBlock
    {
        private readonly AdditiveSpiral _service;

        public AdditiveSpiral_GetValueForBlock()
        {
            _service = new AdditiveSpiral();
        }

        [Fact]
        public void TestBlockOne()
        {
            var result = _service.GetValueForBlock(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestBlockTwo()
        {
            var result = _service.GetValueForBlock(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestBlockThree()
        {
            var result = _service.GetValueForBlock(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestBlockFive()
        {
            var result = _service.GetValueForBlock(5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestForValue()
        {
            var i = 1;
            while (true)
            {
                var result = _service.GetValueForBlock(i);
                if (result > 361527)
                {
                    Console.WriteLine(result);
                    return;
                }
                i++;
            }
        }
    }
}