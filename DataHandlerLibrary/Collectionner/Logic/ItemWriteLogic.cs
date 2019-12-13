using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlerLibrary.Collectionner.DataAccessInterface;
using DataHandlerLibrary.Collectionner.Models;

namespace DataHandlerLibrary.Collectionner.Logic
{
    public class ItemWriteLogic : IItemWriteData
    {
        public void CreateNewItem(ItemModel item)
        {
            var sql = $@"insert into Item (Name,Date,QualityId,StockId) values (@Name,@Date,@qualityId,@StockId)";
        }

        public void CreateNewQuality(string quality)
        {
            var sql = $@"insert into Quality (Quality) values ({quality})";
        }
    }
}
