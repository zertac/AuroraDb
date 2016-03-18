using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDb.enums;

namespace AuroraDb.DataClasses
{
    internal static class DataQueries
    {
        public static Dictionary<ConnectionTypes, Dictionary<string, string>> Queries = new Dictionary<ConnectionTypes, Dictionary<string, string>>();

        static DataQueries()
        {
            Queries.Add(ConnectionTypes.SQL_SERVER, new Dictionary<string, string>());
            Queries.Add(ConnectionTypes.MYSQL, new Dictionary<string, string>());
            Queries.Add(ConnectionTypes.ORACLE, new Dictionary<string, string>());
        }
    }
}
