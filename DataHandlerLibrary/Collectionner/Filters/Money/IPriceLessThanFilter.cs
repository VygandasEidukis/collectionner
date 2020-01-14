namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    interface IPriceLessThanFilter : IBaseFilter
    {
        float MaxPrice { get; set; }

    }
}
