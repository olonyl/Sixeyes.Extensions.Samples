﻿using System.Collections.Generic;

namespace Sixeyes.Extensions.Samples.Demo3.Impl
{
    public abstract class XmlDatasource
    {
        public string Name = "API";
    }

    public class XmlReferenceDataSource : XmlDatasource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code ="xyz", Description ="from XML"},
                new ReferenceDataItem { Code ="xyz", Description ="from XML 2"}
            };
        }
    }
}
