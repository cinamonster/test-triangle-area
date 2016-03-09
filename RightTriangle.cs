using System;

namespace RightTriangleArea
{
    internal class RightTriangle
    {
        private double[] orderedSides;

        private RightTriangle()
        {
        }

        // Initializates RightTriangle class
        /// <param name="orderedSides">Sides of triangle ordered by ascending</param>
        internal RightTriangle(double[] orderedSides)
        {
            this.orderedSides = orderedSides;
        }

        // Returns triangle area
        internal double GetArea()
        {
            return 0.5 * orderedSides[0] * orderedSides[1];
        }
    }
}
