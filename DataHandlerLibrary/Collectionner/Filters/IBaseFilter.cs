using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters
{
    public interface IBaseFilter
    {
        List<ItemModel> GetUnfilteredItems(List<ItemModel> Items);
    }
}
