using System;
using System.Linq;
using UrbanDoodle.Models.Figures;
using UrbanDoodle.Services;

namespace UrbanDoodle
{
    public class AreaCalculator<T> where T : IFigure
    {
        private readonly ITriangleService _triangleService;
        private readonly ICircleService _circleService;

        public AreaCalculator()
        {
            _triangleService = new TriangleService();
            _circleService = new CircleService();
        }
        
        /// <summary>
        /// Calculate figure area
        /// </summary>
        /// <param name="figure">Figure object</param>
        /// <returns>Figure Area</returns>
        /// <exception cref="NullReferenceException">If figure hasn't value</exception>
        /// <exception cref="ArgumentException">If figure hasn't correct value</exception>
        public double Calculate(T figure)
        {
            if (figure == null)
            {
                throw new NullReferenceException("Figure doesn't have value.");
            }

            var genType = figure.GetType().GetInterfaces().First(w => w.IsAssignableTo(typeof(IFigure)));

            return genType switch
            {
                var triangle when triangle == typeof(ITriangle) => _triangleService.GetArea((ITriangle)figure),
                var circle when circle == typeof(ICircle) => _circleService.GetArea((ICircle)figure),
                _ => default
            };
        }
    }
}