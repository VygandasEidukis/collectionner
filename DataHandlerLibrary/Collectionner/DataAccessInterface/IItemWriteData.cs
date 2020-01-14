using DataHandlerLibrary.Collectionner.Models;

namespace DataHandlerLibrary.Collectionner.DataAccessInterface
{
    interface IItemWriteData
    {
        bool CreateNewItem(ItemModel item, QualityModel quality);
        void CreateNewQuality(string quality);
    }
}
