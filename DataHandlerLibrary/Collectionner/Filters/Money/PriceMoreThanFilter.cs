using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlerLibrary.Collectionner.Models;

namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    public class PriceMoreThanFilter : IPriceMoreThanFilter
    {
        public float MinPrice { get; set; }

        public List<ItemModel> GetUnfilteredItems(List<ItemModel> Items = null)
        {
            List<ItemModel> itemsToRemove = new List<ItemModel>();

            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    if (item.EstimatedPrice < MinPrice)
                    {
                        itemsToRemove.Add(item);
                    }
                }
            }

            foreach (var item in itemsToRemove)
            {
                Items.Remove(item);
            }

            return Items;
        }
    }
}
