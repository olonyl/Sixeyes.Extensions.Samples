using NUnit.Framework;
using Sixeyes.Extensions.Samples.Demo3;
using Sixeyes.Extensions.Samples.Demo3.Impl;
using Sixeyes.Extensions.Samples.Demo5;
using System;
using System.Collections.Generic;

namespace Sixeyes.Extensions.Samples.UnitTests.Demo5
{
    class ObjectExtensionsTests
    {
        [Test]
        public void ToJsonString_ConvertObject_ReturnObjectFormatted()
        {
            var obj1 = int.MaxValue;
            TestContext.WriteLine("obj1 - " + obj1.ToJsonString());

            var obj2 = new DateTime(200, 12, 31);
            TestContext.WriteLine("obj2 - " + obj2.ToJsonString());

            var obj3 = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"

            };
            TestContext.WriteLine("obj3 - " + obj3.ToJsonString());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource()
            };
            TestContext.WriteLine("obj4 - " + obj4.ToJsonString());

        }

        [Test]
        public void GetJsonTypeDescription_ConvertObject_ReturnObjectFormatted()
        {
            var obj1 = int.MaxValue;
            TestContext.WriteLine("obj1 - " + obj1.GetJsonTypeDescription());

            var obj2 = new DateTime(200, 12, 31);
            TestContext.WriteLine("obj2 - " + obj2.GetJsonTypeDescription());

            var obj3 = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"

            };
            TestContext.WriteLine("obj3 - " + obj3.GetJsonTypeDescription());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource()
            };
            TestContext.WriteLine("obj4 - " + obj4.GetJsonTypeDescription());

        }
    }
}
