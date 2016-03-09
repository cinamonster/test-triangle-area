using System;
using System.Linq;

namespace RightTriangleArea
{
    public class RightTriangleAreaCalculator
    {
        private RightTriangleAreaCalculator()
        {
        }

        // Returns right triangle area
        /// <param name="triangleSides">Sides of triangle</param>
        public static double GetRightRightTriangleArea(double[] triangleSides)
        {
            if(!ValidateSides(ref triangleSides))
                throw new ArgumentException("Triangle sides are not valid.");

            RightTriangle rightTriangle = new RightTriangle(triangleSides);

            return rightTriangle.GetArea();
        }

        // Returns true if sides are valid for right triangle
        /// <param name="triangleSides">Sides of triangle</param>
        private static bool ValidateSides(ref double[] triangleSides)
        {
            if (triangleSides.Length != 3)
                return false;

            triangleSides = triangleSides.OrderBy(i => i).ToArray();

            return Math.Pow(triangleSides[0], 2) + Math.Pow(triangleSides[1], 2) == Math.Pow(triangleSides[2], 2);
        }
    }
}
