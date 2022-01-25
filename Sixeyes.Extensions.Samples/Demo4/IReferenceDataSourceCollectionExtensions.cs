using Sixeyes.Extensions.Samples.Demo3;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sixeyes.Extensions.Samples.Demo4
{
    public static class IReferenceDataSourceCollectionExtensions
    {

        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IEnumerable<IReferenceDataSource> sources, string code)
        {
            return sources.SelectMany(x => x.GetItemsByCode(code));
        }

        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IEnumerable sources, string code)
        {
            var items = new List<ReferenceDataItem>();

            foreach (var source in sources)
            {
                var castSources = source as IReferenceDataSource;

                if (castSources != null)
                    items.AddRange(castSources.GetItemsByCode(code));
            }
            return items;
        }

    }
}
