using NUnit.Framework;
using Sixeyes.Extensions.Samples.Demo3;
using Sixeyes.Extensions.Samples.Demo3.Impl;
using Sixeyes.Extensions.Samples.Demo4;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sixeyes.Extensions.Samples.UnitTests.Demo4
{
    class IReferenceDataSourceCollectionExtensionTests
    {
        [Test]
        public void GetAllItemsByCode_Count_ReturnArrayOfSources()
        {
            var sources = new IReferenceDataSource[] {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };


            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [Test]
        public void GetAllItemsByCode_AddString_ReturnArrayOfSources()
        {
            var sources = new ArrayList {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };

            sources.Add("I am not a reference data source");

            var items = sources.GetAllItemsByCode("xyz");

            Assert.AreEqual(6, items.Count());
        }


        [Test]
        public void GetAllItemsByCode_UsingEnumerable_ReturnArrayOfSources()
        {
            var sources = new List<IReferenceDataSource> {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };


            var items = sources.GetAllItemsByCode("xyz");

            Assert.AreEqual(6, items.Count());
        }
    }
}
