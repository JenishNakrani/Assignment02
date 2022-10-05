using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;
namespace Assignment02.Test
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void valid_Input1_OutputValidLength()
        {
            int length = 1;
            Rectangle rectangle = new Rectangle(length,10);
            int actual = length;
            int result = rectangle.GetCurrentLength();
            Assert.AreEqual(result, actual);
        }
        [Test]
        public void valid_Input10_OutputValidLength()
        {
            int length = 10;
            Rectangle rectangle = new Rectangle(length, 20);
            int actual = length;
            int result = rectangle.GetCurrentLength();
            Assert.AreEqual(result, actual);
        }
        [Test]
        public void valid_Input20_OutputValidLength()
        {
            int length = 20;
            Rectangle rectangle = new Rectangle(length, 30);
            int actual = length;
            int result = rectangle.GetCurrentLength();
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void valid_Input20_OutputValidNewLength()
        {
            Rectangle rectangle = new Rectangle();
            int length = 20;
            int result = rectangle.SetNewLength(length);
            Assert.AreEqual(result, 20);
        }
        [Test]
        public void valid_Inpu30_OutputValidNewLength()
        {
            Rectangle rectangle = new Rectangle();
            int length = 30;
            int result = rectangle.SetNewLength(length);
            Assert.AreEqual(result, 30);
        }
        [Test]
        public void valid_Input40_OutputValidNewLength()
        {
            Rectangle rectangle = new Rectangle();
            int length = 40;
            int result = rectangle.SetNewLength(length);
            Assert.AreEqual(result, 40);
        }

        [Test]
        public void valid_Input1_OutputValidWidth()
        {
            int width = 1;
            Rectangle rectangle = new Rectangle(20, width);
            int actual = width;
            int result = rectangle.GetCurrentWidth();
            Assert.AreEqual(result, actual);
        }
        [Test]
        public void valid_Input5_OutputValidWidth()
        {
            int width = 5;
            Rectangle rectangle = new Rectangle(25, width);
            int actual = width;
            int result = rectangle.GetCurrentWidth();
            Assert.AreEqual(result, actual);
        }
        [Test]
        public void valid_Input15_OutputValidWidth()
        {
            int width = 15;
            Rectangle rectangle = new Rectangle(30, width);
            int actual = width;
            int result = rectangle.GetCurrentWidth();
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void valid_Input65_OutputValidNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            int width = 65;
            int result = rectangle.SetNewWidth(width);
            Assert.AreEqual(result, 65);
        }
        [Test]
        public void valid_Input75_OutputValidNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            int width = 75;
            int result = rectangle.SetNewWidth(width);
            Assert.AreEqual(result, 75);
        }
        [Test]
        public void valid_Input85_OutputValidNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            int width = 85;
            int result = rectangle.SetNewWidth(width);
            Assert.AreEqual(result, 85);
        }

        [Test]
        public void valid_Input5and10_OutputValidgetPerimeter()
        {
            int length = 5;
            int width = 10;
            int expected = 2 * (length + width);
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetPerimeter();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void valid_Input15and20_OutputValidgetPerimeter()
        {
            int length = 15;
            int width = 20;
            int expected = 2 * (length + width);
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetPerimeter();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void valid_Input35and30_OutputValidgetPerimeter()
        {
            int length = 35;
            int width = 30;
            int expected = 2 * (length + width);
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetPerimeter();
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void valid_Input5and30_OutputValidgetArea()
        {
            int length = 5;
            int width = 60;
            int expected = length * width;
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetArea();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void valid_Input15and30_OutputValidgetArea()
        {
            int length = 15;
            int width = 30;
            int expected = length * width;
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetArea();
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void valid_Input25and35_OutputValidgetArea()
        {
            int length = 25;
            int width = 35;
            int expected = length * width;
            Rectangle rectangle = new Rectangle(length, width);
            int result = rectangle.GetArea();
            Assert.AreEqual(result, expected);
        }

    }
}
