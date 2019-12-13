using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlerLibrary.Collectionner.BaseInterface;

namespace DataHandlerLibrary.Collectionner.Models
{
    class QualityModel : IQuality
    {
        public int Id { get; set; }
        public string Quality { get; set; }
    }
}
