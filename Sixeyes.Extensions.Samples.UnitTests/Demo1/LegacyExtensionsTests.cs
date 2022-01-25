using NUnit.Framework;
using Sixeyes.Extensions.Samples.Demo1;
using System;

namespace Sixeyes.Extensions.Samples.UnitTests.Demo1
{
    class LegacyExtensionsTests
    {
        [Test]
        public void ToLegacyFormat_Format_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());

        }
        [Test]
        public void ToLegacyFormat_Format_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());

        }
        [Test]
        public void ToLegacyFormat_NameSparated()
        {
            var name = "Elton Stoneman";
            Assert.AreEqual("STONEMAN,ELTON", name.ToLegacyFormat());
        }
    }
}
