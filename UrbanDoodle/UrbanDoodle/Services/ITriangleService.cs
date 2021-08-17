using UrbanDoodle.Models.Figures;

namespace UrbanDoodle.Services
{
    public interface ITriangleService
    {
        /// <summary>
        ///     Get triangle Area
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        double GetArea(ITriangle triangle);

        /// <summary>
        ///     Define right triangle or not
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        bool IsRightTriangle(ITriangle triangle);
    }
}