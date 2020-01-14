using DataHandlerLibrary.Collectionner.Filters.Quality;
using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters
{
    public static class FilterHelper
    {
        public static List<ItemModel> ApplyFilter(List<IBaseFilter> filters, List<QualityModel> qualities)
        {
            var items = new ItemReadLogic().ReadItems();

            foreach (var filter in filters)
            {
                items = filter.GetUnfilteredItems(items);
            }

            var qualityFilter = new QualityFilter();
            qualityFilter.Qualities = qualities;
            items = qualityFilter.GetUnfilteredItems(items);

            return items;
        }
    }
}
