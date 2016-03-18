using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDb.Connectors;
using AuroraDb.DataClasses;
using AuroraDb.enums;

namespace AuroraDb
{
    public class Main
    {
        public static Exception AddConnection(ConnectionTypes conType, string conString)
        {
            if (!AuroraConfig.ConnectionStrings.ContainsKey(conType)) AuroraConfig.ConnectionStrings.Add(conType, conString);
            else
            {
                return new Exception("This connection type already added !");
            }

            return null;
        }

        public static Exception AddQuery(ConnectionTypes conType, string queryKey, string query)
        {
            if (DataQueries.Queries[conType] == null) DataQueries.Queries[conType] = new Dictionary<string, string>();

            if (!DataQueries.Queries[conType].ContainsKey(queryKey)) DataQueries.Queries[conType].Add(queryKey, query);
            else return new Exception("This query aleady added for this connection type !");

            return null;
        }

        public static object ExecuteCommand(ConnectionTypes conType, string queryKey, ReturnTypes returnType, List<DbParam> values)
        {
            switch (conType)
            {
                case ConnectionTypes.MYSQL:
                    {
                        var dt = new AMySqlConnector(AuroraConfig.ConnectionStrings[conType]);
                        var result = dt.ExecCommand(queryKey, values, returnType);

                        return result;
                    }
                case ConnectionTypes.SQL_SERVER:
                    {
                        var dt = new AMSqlConnector(AuroraConfig.ConnectionStrings[conType]);
                        var result = dt.ExecCommand(queryKey, values, returnType);

                        return result;
                    }
                case ConnectionTypes.ORACLE:
                    {
                        var dt = new AOracleConnector(AuroraConfig.ConnectionStrings[conType]);
                        var result = dt.ExecCommand(queryKey, values, returnType);

                        return result;
                    }
            }

            return null;
        }
    }
}