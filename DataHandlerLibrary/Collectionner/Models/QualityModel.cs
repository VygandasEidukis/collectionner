using DataHandlerLibrary.Collectionner.BaseInterface;

namespace DataHandlerLibrary.Collectionner.Models
{
    public class QualityModel : IQuality
    {
        public int Id { get; set; }
        public string Quality { get; set; }

        public override string ToString()
        {
            return Quality;
        }
    }
}
