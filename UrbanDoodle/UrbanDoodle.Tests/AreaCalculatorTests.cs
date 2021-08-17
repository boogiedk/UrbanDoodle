using System;
using NUnit.Framework;
using UrbanDoodle.Models.Figures;
using UrbanDoodle.Tests.ClientFigures;

namespace UrbanDoodle.Tests
{
    public class AreaCalculatorTests
    {
        [Test]
        public void Calculate_ReturnsAreaOfTriangle_ShouldCalculateAndReturnArea()
        {
            // arrange
            var calc = new AreaCalculator<IFigure>();
            
            // act
            var area = calc.Calculate(new Triangle
            {
                FirstSideOfTriangle = 3,
                SecondSideOfTriangle = 4,
                ThirdSideOfTriangle = 5
            });
            
            // assert
            Assert.AreEqual(6,area);
        }
        
        [Test]
        public void Calculate_ReturnsAreaOfCircle_ShouldCalculateAndReturnArea()
        {
            // arrange
            var calc = new AreaCalculator<IFigure>();
            
            // act
            var area = calc.Calculate(new Circle
            {
                Radius = 5
            });
            
            // assert
            Assert.AreEqual(78.5398,Math.Round(area, 4));
        }
        
        [Test]
        public void Calculate_ReturnsErrorWhenCalcAreaTriangle_ShouldThrowException()
        {
            // arrange
            var calc = new AreaCalculator<IFigure>();
            var messageError = "No correct value for calculate triangle area.";

            // act
            var ex = Assert.Throws<ArgumentException>(() => calc.Calculate(new Triangle
            {
                FirstSideOfTriangle = 0,
                SecondSideOfTriangle = 4,
                ThirdSideOfTriangle = 5
            }));
            
            // assert
            Assert.AreEqual(ex.Message,messageError);
        }
        
        [Test]
        public void Calculate_ReturnsErrorWhenCalcAreaCircle_ShouldThrowException()
        {
            // arrange
            var calc = new AreaCalculator<IFigure>();
            var messageError = "No correct value for calculate circle area.";

            // act
            var ex = Assert.Throws<ArgumentException>(() => calc.Calculate(new Circle()
            {
                Radius = -25
            }));
            
            // assert
            Assert.AreEqual(ex.Message,messageError);
        }
        
        [Test]
        public void Calculate_ShouldCompleteAllCase_ShouldDoneSuccess()
        {
            // arrange
            var calc = new AreaCalculator<IFigure>();
            var argumentExceptionCircleText = "No correct value for calculate circle area.";
            var argumentExceptionTriangleText = "No correct value for calculate triangle area.";
            var nullExceptionText = "Figure doesn't have value.";

            // act
            var nullReferenceCircle = Assert.Throws<NullReferenceException>(() => calc.Calculate(null));
            //var testNoFigure = calc.Calculate(new Person()); no compile
            
            // circle
            var argumentExceptionCircle = Assert.Throws<ArgumentException>(() => calc.Calculate(new Circle()));

            // trianagle;
            var argumentExceptionTriangle = Assert.Throws<ArgumentException>(() => calc.Calculate(new Triangle()));
            var argumentExceptionTriangleNotExist = Assert.Throws<ArgumentException>(() => calc.Calculate(new Triangle
            {
                FirstSideOfTriangle = 1,
                SecondSideOfTriangle = 10,
                ThirdSideOfTriangle = 100
            }));
            
            // assert
            Assert.AreEqual(nullReferenceCircle.Message,nullExceptionText);
            Assert.AreEqual(argumentExceptionCircle.Message,argumentExceptionCircleText);
            Assert.AreEqual(argumentExceptionTriangle.Message,argumentExceptionTriangleText);
            Assert.AreEqual(argumentExceptionTriangleNotExist.Message,argumentExceptionTriangleText);
        }
    }
}