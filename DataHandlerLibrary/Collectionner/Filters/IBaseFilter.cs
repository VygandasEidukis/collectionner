using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters
{
    interface IBaseFilter
    {
        string Name { get; set; }

        List<ItemModel> GetUnfilteredItems(List<ItemModel> CurrentItems, List<ItemModel> FilteredItems);
    }
}
