using System;
using Xunit;

namespace Spiral.Tests
{
    public class SpiralService_GetPosition
    {
        private readonly SpiralService _service;

        public SpiralService_GetPosition()
        {
            _service = new SpiralService();
        }

        [Fact]
        public void TestTwo()
        {
            var point = _service.GetPosition(2);
            Assert.Equal(1, point.X);
            Assert.Equal(0, point.Y);
        }

        [Fact]
        public void TestThree()
        {
            var point = _service.GetPosition(3);
            Assert.Equal(1, point.X);
            Assert.Equal(1, point.Y);
        }

        [Fact]
        public void TestFour()
        {
            var point = _service.GetPosition(4);
            Assert.Equal(0, point.X);
            Assert.Equal(1, point.Y);
        }

        [Fact]
        public void TestTwelve()
        {
            var point = _service.GetPosition(12);
            Assert.Equal(2, point.X);
            Assert.Equal(1, point.Y);
        }

        [Fact]
        public void TestTwentyThree()
        {
            var point = _service.GetPosition(23);
            Assert.Equal(0, point.X);
            Assert.Equal(-2, point.Y);
        }

        [Fact]
        public void TestBig()
        {
            var point = _service.GetPosition(1024);
            var distance = Math.Abs(point.X) + Math.Abs(point.Y);
            Assert.Equal(31, distance);
        }

        [Fact]
        public void TestActual()
        {
            var point = _service.GetPosition(361527);
            var distance = Math.Abs(point.X) + Math.Abs(point.Y);
            Console.WriteLine(distance);
        }
    }
}
