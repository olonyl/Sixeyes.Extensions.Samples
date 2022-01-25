using NUnit.Framework;
using Sixeyed.Extensions.Advanced.Demo1;
using System.Threading;

namespace Sixeyed.Extensions.Advanced.UnitTests.Demo1
{
    class InstrumentationTests
    {
        [Test]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());
        }

        [Test]
        public void GetPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetPreciseElapsedTime();

            Assert.That(1, Is.EqualTo(elapsed).Within(.75));
        }

        [Test]
        public void GetReallyPrecisedElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetReallyPreciseElapsedTime();

            Assert.That(750, Is.EqualTo(elapsed).Within(elapsed * .1));
        }
    }
}
