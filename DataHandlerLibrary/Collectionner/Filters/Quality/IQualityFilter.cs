using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters.Quality
{
    interface IQualityFilter : IBaseFilter
    {
        List<QualityModel> Qualities { get; set; }
    }
}
