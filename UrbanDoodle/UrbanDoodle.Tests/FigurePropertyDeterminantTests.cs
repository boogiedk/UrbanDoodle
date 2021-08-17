using System;
using NUnit.Framework;
using UrbanDoodle.Tests.ClientFigures;

namespace UrbanDoodle.Tests
{
    public class FigurePropertyDeterminantTests
    {
        [Test]
        public void IsRightTriangle_ReturnsIsRightTriangle_ShouldDefineIsRightTriangle()
        {
            // arrange
            var determinant = new FigurePropertyDeterminant<Triangle>();
            var nullExceptionText = "Figure doesn't have value.";
            
            // act
            var isRightTriangle1 = determinant.IsRightTriangle(new Triangle
            {
                FirstSideOfTriangle = 4,
                SecondSideOfTriangle = 3,
                ThirdSideOfTriangle = 5
            });
            
            var isRightTriangle2 = determinant.IsRightTriangle(new Triangle
            {
                FirstSideOfTriangle = 7,
                SecondSideOfTriangle = 6,
                ThirdSideOfTriangle = 8
            });
            
            var isRightTriangle3 = determinant.IsRightTriangle(new Triangle
            {
                FirstSideOfTriangle = 12.12,
                SecondSideOfTriangle = 11.75,
                ThirdSideOfTriangle = 13.52
            });
            
            var nullException = Assert.Throws<NullReferenceException>(() => determinant.IsRightTriangle(null));
            
            // assert
            Assert.True(isRightTriangle1);
            Assert.False(isRightTriangle2);
            Assert.False(isRightTriangle3);
            Assert.AreEqual(nullException.Message, nullExceptionText);
        }
        
        [Test]
        public void IsRightTriangle_ShouldCompleteAllCase_ShouldDoneSuccess()
        {
            // arrange
            var determinant = new FigurePropertyDeterminant<Triangle>();
            var argumentExceptionTriangleText = "No correct value for calculate triangle area.";
            var nullExceptionText = "Figure doesn't have value.";
            
            // act;
            
            var nullException = Assert.Throws<NullReferenceException>(() => determinant.IsRightTriangle(null));
            
            var argumentException = Assert.Throws<ArgumentException>(() => determinant.IsRightTriangle(new Triangle()));
            
            // assert
            Assert.AreEqual(argumentException.Message, argumentExceptionTriangleText);
            Assert.AreEqual(nullException.Message, nullExceptionText);
        }
    }
}