using DataAccessLibrary.DataAccess;
using DataHandlerLibrary.Collectionner.Models;
using System.Collections.Generic;

namespace DataHandlerLibrary.Collectionner.Logic
{
    public static class QualityReadLogic
    {
        public static List<QualityModel> ReadQualities()
        {
            const string sql = @"SELECT * FROM Quality";

            return DataAccess.LoadData<QualityModel>(sql);
        }
    }
}
