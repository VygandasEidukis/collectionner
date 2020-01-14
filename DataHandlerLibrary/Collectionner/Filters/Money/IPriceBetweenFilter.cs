namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    interface IPriceBetweenFilter : IBaseFilter
    {
        float MinPrice { get; set; }
        float MaxPrice { get; set; }
    }
}
