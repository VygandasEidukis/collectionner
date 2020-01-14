namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    interface IPriceMoreThanFilter : IBaseFilter
    {
        float MinPrice { get; set; }

    }
}
