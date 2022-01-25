using System.Collections.Generic;

namespace Sixeyes.Extensions.Samples.Demo3.Impl
{
    public abstract class ApiDatasource
    {
        public string Name = "API";
    }

    public class ApiReferenceDataSource : ApiDatasource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code ="xyz", Description ="from API"},
                new ReferenceDataItem { Code ="xyz", Description ="from API 2"}
            };
        }
    }
}
