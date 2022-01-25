using System.Collections.Generic;

namespace Sixeyes.Extensions.Samples.Demo3.Impl
{
    public abstract class SqlDatasource
    {
        public string Name = "API";
    }

    public class SqlReferenceDataSource : SqlDatasource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code ="xyz", Description ="from SQL"},
                new ReferenceDataItem { Code ="xyz", Description ="from SQl 2"}
            };
        }
    }
}
