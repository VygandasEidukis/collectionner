using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters.Quality
{
    interface IQualityFilter
    {
        List<QualityModel> Qualities { get; set; }

        List<ItemModel> FilterItems(List<QualityModel> qualities);
    }
}
