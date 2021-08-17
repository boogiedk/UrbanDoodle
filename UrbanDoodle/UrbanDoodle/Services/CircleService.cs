using System;
using UrbanDoodle.Models.Figures;

namespace UrbanDoodle.Services
{
    public class CircleService : ICircleService
    {
        public double GetArea(ICircle circle)
        {
            if (!IsAboveZero(circle))
            {
                throw new ArgumentException("No correct value for calculate circle area.");
            }

            return CalculateArea(circle);
        }

        private double CalculateArea(ICircle circle)
        {
            return Math.PI * (circle.Radius * circle.Radius);
        }
        
        private bool IsAboveZero(ICircle circle)
        {
            return circle.Radius > 0;
        }
    }
}