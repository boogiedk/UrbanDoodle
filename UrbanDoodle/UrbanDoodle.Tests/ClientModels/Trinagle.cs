using UrbanDoodle.Models.Figures;

namespace UrbanDoodle.Tests.ClientFigures
{
    public class Triangle : ITriangle
    {
        public double FirstSideOfTriangle { get; set; }
        public double SecondSideOfTriangle { get; set; }
        public double ThirdSideOfTriangle { get; set; }
    }
}