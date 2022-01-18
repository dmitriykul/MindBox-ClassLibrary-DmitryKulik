using System;
using DmitryKulik_MindBoxClassLibrary.Implementations;
using NUnit.Framework;

namespace DmitryKulik_MindBoxTest
{
    public class CircleTest
    {
        private Circle _circle;

        [SetUp]
        public void Setup()
        {
            _circle = new Circle() { Radius = 5 };
        }

        [Test]
        public void TestWhenCorrectRadiusShouldReturn78()
        {
            Assert.AreEqual(79, Math.Round(_circle.Area()));
        }

        [Test]
        public void TestWhenRadiusNegativeShouldThrowException()
        {
            var circle = new Circle() { Radius = -1 };
            var ex = new ArgumentException();
            try
            {
                circle.Area();
            }
            catch (ArgumentException e)
            {
                ex = e;
            }
            Assert.AreEqual("Радиус должен быть больше нуля", ex.Message);
        }
    }
}