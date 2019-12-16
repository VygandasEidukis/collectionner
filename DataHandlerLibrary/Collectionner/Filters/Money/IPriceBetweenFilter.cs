using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    interface IPriceBetweenFilter : IBaseFilter
    {
        float MinPrice { get; set; }
        float MaxPrice { get; set; }
    }
}
