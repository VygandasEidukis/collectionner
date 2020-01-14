using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.DataAccessInterface
{
    interface IItemReadData
    {
        List<ItemModel> ReadItems();
    }
}
