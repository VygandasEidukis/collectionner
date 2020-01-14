using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    public class DateNewerThanFilter : IOlderThanDateFilter
    {
        public DateTime LatestDate { get; set; } = new DateTime();

        public DateNewerThanFilter()
        {
            LatestDate = DateTime.Today;
        }

        public List<ItemModel> GetUnfilteredItems(List<ItemModel> Items = null)
        {
            List<ItemModel> itemsToRemove = new List<ItemModel>();

            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    if (item.Date < LatestDate)
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
