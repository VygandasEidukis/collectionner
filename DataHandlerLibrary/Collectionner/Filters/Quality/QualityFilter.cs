using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters.Quality
{
    public class QualityFilter : IQualityFilter
    {
        public List<QualityModel> Qualities { get; set; }

        public List<ItemModel> GetUnfilteredItems(List<ItemModel> Items = null)
        {
            List<ItemModel> itemsToRemove = new List<ItemModel>();
            foreach (var item in Items)
            {
                bool keep = false;
                foreach (var quality in Qualities)
                {
                    if (item.QualityId == quality.Id)
                        keep = true;
                }
                if (!keep)
                    itemsToRemove.Add(item);
            }

            foreach (var item in itemsToRemove)
            {
                Items.Remove(item);
            }

            return Items;
        }
    }
}
