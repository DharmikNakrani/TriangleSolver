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
        [Test]
        public void ValidEquilateralTriangleTest()
        {
            var side1 = 10;
            var side2 = 10;
            var side3 = 10;

            var expected = "Equilateral triangle";

            // Create an instance of your triangle class with sides for a valid equilateral triangle
            var actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
