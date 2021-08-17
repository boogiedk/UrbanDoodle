namespace UrbanDoodle.Models.Figures
{
    /// <summary>
    ///     Triangle
    /// </summary>
    public interface ITriangle : IFigure
    {
        public double FirstSideOfTriangle { get; set; }
        public double SecondSideOfTriangle { get; set; }
        public double ThirdSideOfTriangle { get; set; }
    }
}