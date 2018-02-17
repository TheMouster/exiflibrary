using System;
using ExifLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExifLibrary
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestGPSDate()
        {
            var expectedResult = new DateTime(2017, 09, 11);

            var image = ImageFile.FromFile("UnitTestImage.jpg");
            var actualResult = image.Properties[ExifTag.GPSDateStamp].Value;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
