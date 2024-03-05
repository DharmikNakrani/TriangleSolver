using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TriangleSolver;

namespace TestClass
{
    public class Class1
    {
        //test caes 1
        [Test]
        public void EquilateteralTriangle_Input10and10and10_OutputEquilateralTriangle()
        {
            //Arrange
            int side1 = 10;
            int side2 = 10;
            int side3 = 10;

            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 2
        [Test]
        public void IsoscelesTriangle_Input40and40and10_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 40;
            int side2 = 40;
            int side3 = 10;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 2
        [Test]
        public void IsoscelesTriangle_Input50and20and50_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 50;
            int side2 = 20;
            int side3 = 50;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 2
        [Test]
        public void IsoscelesTriangle_Input30and60and60_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 30;
            int side2 = 60;
            int side3 = 60;

            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }    
}

