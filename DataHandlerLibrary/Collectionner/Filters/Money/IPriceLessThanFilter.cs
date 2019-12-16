﻿using DataHandlerLibrary.Collectionner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlerLibrary.Collectionner.Filters.Money
{
    interface IPriceLessThanFilter : IBaseFilter
    {
        float MaxPrice { get; set; }

        List<ItemModel> FilterItems(float MaxPrice);
    }
}
