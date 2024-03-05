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
        //test caes 
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
    }
}
