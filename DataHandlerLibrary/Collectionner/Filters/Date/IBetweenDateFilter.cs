using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    interface IBetweenDateFilter : IBaseFilter
    {
        DateTime OldestDate { get; set; }
        DateTime LatestDate { get; set; }
    }
}
