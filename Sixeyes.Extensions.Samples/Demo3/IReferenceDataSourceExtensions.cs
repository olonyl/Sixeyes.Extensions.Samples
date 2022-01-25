using System.Collections.Generic;
using System.Linq;

namespace Sixeyes.Extensions.Samples.Demo3
{
    public static class IReferenceDataSourceExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetItemsByCode(this IReferenceDataSource source, string code)
        {
            return source.GetItems().Where(i => i.Code == code);
        }
    }
}
