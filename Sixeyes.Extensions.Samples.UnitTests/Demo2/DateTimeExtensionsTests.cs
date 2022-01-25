using NUnit.Framework;
using System;

namespace Sixeyes.Extensions.Samples.UnitTests.Demo2
{
    class DateTimeExtensionsTests
    {
        [Test]
        public void ToXmlDateTime_Format_ReturnsCorrectFormat()
        {
            var datetime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951Z", datetime.ToXmlDateTime());
        }
        [Test]
        public void ToXmlDateTime_FormatWithModel_ReturnsCorrectFormat()
        {
            var datetime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951-05:00", datetime.ToXmlDateTime(System.Xml.XmlDateTimeSerializationMode.Local));
            Assert.AreEqual("2013-10-24T13:10:15.951-05:00", DateTimeExtensions.ToXmlDateTime(datetime, System.Xml.XmlDateTimeSerializationMode.Local));
        }
    }
}
