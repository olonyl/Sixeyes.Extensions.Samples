using NUnit.Framework;
using Sixeyes.Extensions.Samples.Demo3;
using Sixeyes.Extensions.Samples.Demo3.Impl;
using System.Linq;

namespace Sixeyes.Extensions.Samples.UnitTests.Demo3
{
    public class ReferenceDataSourceTests
    {
        [Test]
        public void GetItems_CallGetItems_ReturnTwoItems()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());

        }

        [Test]
        public void GetItemsByCode_OnSqlSentCodeXYZ_ReturnsTotalElementsWithThatCode()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

        }

        [Test]
        public void GetItemsByCode_OnXmlSentCodeXYZ_ReturnsTotalElementsWithThatCode()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

        }

        [Test]
        public void GetItemsByCode_OnApiSentCodeXYZ_ReturnsTotalElementsWithThatCode()
        {
            var source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

        }
    }
}
