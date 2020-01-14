using DataAccessLibrary.DataAccess;
using DataHandlerLibrary.Collectionner.DataAccessInterface;
using DataHandlerLibrary.Collectionner.Models;

namespace DataHandlerLibrary.Collectionner.Logic
{
    public class ItemWriteLogic : IItemWriteData
    {
        public bool CreateNewItem(ItemModel item, QualityModel quality)
        {
            if (!item.IsValid()) return false;
            var sql = $@"insert into Item (Name,Date,QualityId,StockId, EstimatedPrice) values (@Name,CAST('{item.Date.Date:yyyy/MMMM/dd}' as DATE),@qualityId,@StockId, @EstimatedPrice)";

            item.QualityId = quality.Id;

            DataAccess.SaveData(sql, item);

            return true;
        }

        public void CreateNewQuality(string quality)
        {
            var sql = $@"insert into Quality (Quality) values ({quality})";
        }
    }
}
