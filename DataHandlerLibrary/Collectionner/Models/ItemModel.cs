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
        public string StockId { get; set; }
        public float EstimatedPrice { get; set; }
        public string Quality { get; set; }

        public ItemModel()
        {
            Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        }

        public bool IsValid()
        {
            //if doesn't have name
            if (String.IsNullOrEmpty(Name)) return false;
            //if doesn't have in stock
            if (String.IsNullOrEmpty(StockId)) return false;
            //if price isn't set
            if (EstimatedPrice == 0) return false;

            return true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
