using System;

namespace DataHandlerLibrary.Collectionner.Filters.Date
{
    interface INewerThanDateFliter : IBaseFilter
    {
        DateTime OldestDate { get; set; }
    }
}
