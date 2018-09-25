using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace Assignment1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var testRectangle = new Rectangle();

            var testResultLength = testRectangle.GetLength();
            Assert.AreEqual(1, testResultLength, "I expected to be default rectangle length = 1");

            var testResultWidth = testRectangle.GetWidth();
            Assert.AreEqual(1, testResultWidth, "I expected to be default rectangle width = 1");

            var testResultArea = testRectangle.GetArea();
            Assert.AreEqual(1, testResultArea, "I expected to be default area and that is area 1l x 1w = 1");             
            
            var testResultPerimeter = testRectangle.GetPerimeter();            
            Assert.AreEqual(2, testResultPerimeter, "I expected to be default perimeter and that is 2*(1l x 1w) = 2");

            var testResultSetLength = testRectangle.SetLength(20);
            Assert.AreEqual(20, testResultSetLength, "I expected the rectangle's lenght to be set as 20");

            var testResultSetWidth = testRectangle.SetLength(10);
            Assert.AreEqual(10, testResultSetWidth, "I expected the rectangle's lenght to be set as 20");


            //Extra tests using the non-default constructor
            var testRectangle2 = new Rectangle(5, 5);
            var testResultArea2 = testRectangle2.GetArea();
            Assert.AreEqual(25, testResultArea2, "I expected to be lenght and width input by the user and that is 5l x 5w = 25");
            var testResultPerimeter2 = testRectangle2.GetPerimeter();
            Assert.AreEqual(50, testResultPerimeter2, "I expected to be length and width input by the user and that is 2(5l x 1w) = 2");

        }
    }
}
