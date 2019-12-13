using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlerLibrary.Collectionner.BaseInterface;

namespace DataHandlerLibrary.Collectionner.Models
{
    public class ItemModel : ICollectorItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int QualityId { get; set; }
        public int StockId { get; set; }
        public string Quality { get; set; }
    }
}
