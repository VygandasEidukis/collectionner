using System;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    interface IOlderThanDateFilter : IBaseFilter
    {
        DateTime LatestDate { get; set; }
    }
}
