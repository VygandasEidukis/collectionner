using System;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    interface IBetweenDateFilter : IBaseFilter
    {
        DateTime OldestDate { get; set; }
        DateTime LatestDate { get; set; }
    }
}
