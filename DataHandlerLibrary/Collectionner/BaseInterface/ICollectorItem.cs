using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.BaseInterface
{
    public interface ICollectorItem : IQuality
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Date { get; set; }
        int QualityId { get; set; }
        int StockId { get; set; }
    }
}
