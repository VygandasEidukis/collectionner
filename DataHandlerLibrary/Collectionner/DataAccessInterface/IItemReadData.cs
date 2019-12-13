using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlerLibrary.Collectionner.Models;

namespace DataHandlerLibrary.Collectionner.DataAccessInterface
{
    interface IItemReadData
    {
        List<ItemModel> ReadItems();
    }
}
