using System.Collections.Generic;

namespace Sixeyes.Extensions.Samples.Demo3
{
    public interface IReferenceDataSource
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}
