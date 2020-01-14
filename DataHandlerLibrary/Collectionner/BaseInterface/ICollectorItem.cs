using System;

namespace DataHandlerLibrary.Collectionner.BaseInterface
{
    public interface ICollectorItem : IQuality
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Date { get; set; }
        int QualityId { get; set; }
        string StockId { get; set; }
        float EstimatedPrice { get; set; }
    }
}
