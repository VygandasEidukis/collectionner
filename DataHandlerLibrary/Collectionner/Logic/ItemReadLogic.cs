using DataAccessLibrary.DataAccess;
using DataHandlerLibrary.Collectionner.DataAccessInterface;
using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Logic
{
    public class ItemReadLogic : IItemReadData
    {
        public List<ItemModel> ReadItems()
        {
            var sql = @"SELECT * FROM Item inner join Quality as q on q.id = QualityId";

            return DataAccess.LoadData<ItemModel>(sql);
        }
    }
}
