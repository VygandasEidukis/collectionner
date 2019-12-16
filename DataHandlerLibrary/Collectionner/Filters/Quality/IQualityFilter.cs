using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters.Quality
{
    interface IQualityFilter : IBaseFilter
    {
        List<QualityModel> Qualities { get; set; }
    }
}
