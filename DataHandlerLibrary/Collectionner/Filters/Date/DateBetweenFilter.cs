using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    public class DateBetweenFilter : IBetweenDateFilter
    {
        public DateTime OldestDate { get; set; } = new DateTime();
        public DateTime LatestDate { get; set; } = new DateTime();

        public DateBetweenFilter()
        {
            OldestDate = DateTime.Today;
            LatestDate = DateTime.Today;
        }

        public List<ItemModel> GetUnfilteredItems(List<ItemModel> Items = null)
        {
            List<ItemModel> itemsToRemove = new List<ItemModel>();

            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    if (item.Date < LatestDate || item.Date > OldestDate)
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
