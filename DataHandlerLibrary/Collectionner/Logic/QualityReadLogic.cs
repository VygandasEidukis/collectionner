using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.DataAccess;
using DataHandlerLibrary.Collectionner.Models;

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
