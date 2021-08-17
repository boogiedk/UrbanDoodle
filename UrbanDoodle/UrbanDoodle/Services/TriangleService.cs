using System;
using UrbanDoodle.Models.Figures;

namespace UrbanDoodle.Services
{
    public class TriangleService : ITriangleService
    {
        public double GetArea(ITriangle triangle)
        {
            if (!(IsAboveZero(triangle) && IsTriangleExists(triangle)))
            {
                throw new ArgumentException("No correct value for calculate triangle area.");
            }

            return CalculateArea(triangle);
        }

        public bool IsRightTriangle(ITriangle triangle)
        {
            if (!(IsAboveZero(triangle) && IsTriangleExists(triangle)))
            {
                throw new ArgumentException("No correct value for calculate triangle area.");
            }

            return triangle.ThirdSideOfTriangle * triangle.ThirdSideOfTriangle ==
                         triangle.SecondSideOfTriangle * triangle.SecondSideOfTriangle +
                          triangle.FirstSideOfTriangle * triangle.FirstSideOfTriangle;
            
        }

        private double CalculateArea(ITriangle triangle)
        {
            var p = (triangle.FirstSideOfTriangle + triangle.SecondSideOfTriangle + triangle.ThirdSideOfTriangle) / 2;
            return Math.Sqrt(p * (p - triangle.FirstSideOfTriangle) * (p - triangle.SecondSideOfTriangle) *
                             (p - triangle.ThirdSideOfTriangle));
        }
        
        private bool IsAboveZero(ITriangle triangle)
        {
            return triangle.FirstSideOfTriangle > 0 
                   && triangle.SecondSideOfTriangle > 0 &&
                   triangle.ThirdSideOfTriangle > 0;
        }
        
        private bool IsTriangleExists(ITriangle triangle)
        {
            return triangle.FirstSideOfTriangle + triangle.SecondSideOfTriangle > triangle.ThirdSideOfTriangle &&
                   triangle.FirstSideOfTriangle + triangle.ThirdSideOfTriangle > triangle.SecondSideOfTriangle &&
                   triangle.SecondSideOfTriangle + triangle.ThirdSideOfTriangle > triangle.FirstSideOfTriangle;
        }

    }
}