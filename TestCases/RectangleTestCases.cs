using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nunit.Testing.Rectangle;

namespace TestCases
{
    [TestFixture]
    public class RectangleTestCases
    {
        [Test]
        public void GetLength_InputLength8Width5_Returns8()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.GetLength(), Is.EqualTo(8));
        }


        [Test]
        public void SetLength_InputLength8Width5_ChangesLengthTo4()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.SetLength(4), Is.EqualTo(4));
        }

        [Test]
        public void GetWidth_InputLength8Width5_Returns5()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.GetWidth(), Is.EqualTo(5));
        }

        [Test]
        public void SetWidth_InputLength8Width5_ChangesWidthTo3()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.SetWidth(3), Is.EqualTo(3));
        }

        [Test]
        public void GetPerimeter_InputLength8Width5_Returns26()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.GetPerimeter(), Is.EqualTo(26));
        }

        [Test]
        public void GetArea_InputLength8Width5_Returns40()
        {
            Rectangle rectangleUnderTest = new Rectangle(8, 5);
            Assert.That(rectangleUnderTest.GetArea(), Is.EqualTo(40));
        }
    }
}
