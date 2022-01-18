using System;
using DmitryKulik_MindBoxClassLibrary.Implementations;
using NUnit.Framework;

namespace DmitryKulik_MindBoxTest
{
    public class TriangleTests
    {
        private Triangle _triangle;
        [SetUp]
        public void Setup()
        {
            _triangle = new Triangle() { A = 5, B = 3, C = 4 };
        }

        [Test]
        public void TestWhenRectangularShouldReturnTrue()
        {
            Assert.True(_triangle.IsRectangular());
        }

        [Test]
        public void TestWhenCorrectShouldReturnAreaSix()
        {
            Assert.AreEqual(6, _triangle.Area());
        }

        [Test]
        public void TestWhenNegativeSideShouldThrowException()
        {
            var triangle = new Triangle() { A = -1, B = 1, C = 2 };
            try
            {
                triangle.Area();
            }
            catch (ArgumentException ex)
            {
                
            }
        }

    }
}