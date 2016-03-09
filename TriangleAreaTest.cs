using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RightTriangleArea;

namespace RightTriangleAreaTestProject
{
    [TestClass]
    public class RightTriangleAreaTest 
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSidesCount()
        {
            RightTriangleAreaCalculator.GetRightRightTriangleArea(new double[] {4, 4});
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleIsRight()
        {
            RightTriangleAreaCalculator.GetRightRightTriangleArea(new double[] { 4, 4, 4 });
        }

        [TestMethod]
        public void TestArea()
        {
            double[] sides = {3, 4, 5};

            double S = RightTriangleAreaCalculator.GetRightRightTriangleArea(sides);

            Assert.AreEqual(S, 6);
        }
    }
}
