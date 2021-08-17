using UrbanDoodle.Models.Figures;

namespace UrbanDoodle.Services
{
    public interface ICircleService
    {
        /// <summary>
        ///     Get circle area
        /// </summary>
        /// <param name="circle"></param>
        /// <returns></returns>
        double GetArea(ICircle circle);
    }
}