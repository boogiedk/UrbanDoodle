using System;
using UrbanDoodle.Models.Figures;
using UrbanDoodle.Services;

namespace UrbanDoodle
{
    public class FigurePropertyDeterminant<T> where T : ITriangle
    {
        private readonly ITriangleService _triangleService;
        
        public FigurePropertyDeterminant()
        {
            _triangleService = new TriangleService();
        }
        
        /// <summary>
        /// Define is right triangle
        /// </summary>
        /// <param name="triangle">Figure object</param>
        /// <returns>Is right triangle</returns>
        /// <exception cref="NullReferenceException">If figure hasn't value</exception>
        /// <exception cref="ArgumentException">If figure hasn't correct value</exception>
        public bool IsRightTriangle(T triangle)
        {
            if (triangle == null)
            {
                throw new NullReferenceException("Figure doesn't have value.");
            }
            
            return _triangleService.IsRightTriangle(triangle);
        }
    }
}