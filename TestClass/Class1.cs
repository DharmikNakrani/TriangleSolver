﻿using System;
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

        //test caes 3
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

        //test caes 4
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

        //test caes 5
        [Test]
        public void ScaleneTriangle_Input12and25and34_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 12;
            int side2 = 25;
            int side3 = 34;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 6
        [Test]
        public void ScaleneTriangle_Input33and22and14_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 33;
            int side2 = 22;
            int side3 = 14;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 7
        [Test]
        public void ScaleneTriangle_Input22and15and34_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 22;
            int side2 = 15;
            int side3 = 34;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 8
        [Test]
        public void ScaleneTriangle_Input42and51and30_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 42;
            int side2 = 51;
            int side3 = 30;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 9
        [Test]
        public void ScaleneTriangle_Input15and22and21_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 15;
            int side2 = 22;
            int side3 = 21;

            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 10
        [Test]
        public void ZeroLengthTriangle_Input0and12and20_OutputZeroLengthTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 12;
            int side3 = 20;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 11
        [Test]
        public void ZeroLengthTriangle_Input12and0and0_OutputZeroLengthTriangle()
        {
            //Arrange
            int side1 = 12;
            int side2 = 0;
            int side3 = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 12
        [Test]
        public void ZeroLengthTriangle_Input0and0and0_OutputZeroLengthTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 13
        [Test]
        public void InvalidResponse_Input10and10and20_OutputInvalidResponse()
        {
            //Arrange
            int side1 = 10;
            int side2 = 10;
            int side3 = 20;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 14
        [Test]
        public void InvalidResponse_Input10and20and30_OutputInvalidResponse()
        {
            //Arrange
            int side1 = 10;
            int side2 = 20;
            int side3 = 30;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        //test caes 15
        [Test]
        public void InvalidResponse_Input20and40and60_OutputInvalidResponse()
        {
            //Arrange
            int side1 = 20;
            int side2 = 40;
            int side3 = 60;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }    
}

