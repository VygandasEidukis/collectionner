using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Filters
{
    public interface IBaseFilter
    {
        List<ItemModel> GetUnfilteredItems(List<ItemModel> Items);
    }
}
