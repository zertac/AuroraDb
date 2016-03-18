using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDb.DataClasses;
using AuroraDb.enums;
using MySql.Data.MySqlClient;
using Oracle.DataAccess.Client;

namespace AuroraDb.Connectors
{
    public class AMySqlConnector
    {
        private MySqlConnection _dnCon;

        public AMySqlConnector(string cnnStr = "")
        {
            OpenConnection(cnnStr);
        }

        ~AMySqlConnector()
        {
            CloseConnection();
        }

        private void OpenConnection(string cnnStr)
        {
            try
            {
                _dnCon = new MySqlConnection(cnnStr);
                if (_dnCon.State == ConnectionState.Closed) _dnCon.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        #region DON'T TOUCH
        private void CloseConnection()
        {
            if (_dnCon == null) return;
            if (_dnCon.State != ConnectionState.Closed)
            {
                _dnCon.Close();
                _dnCon.Dispose();
            }
            else _dnCon.Dispose();
        }

        public void CloseAllConnections()
        {
            CloseConnection();
        }

        public object ExecCommand(string queryKey, List<DbParam> values, ReturnTypes returnType)
        {
            var query = DataQueries.Queries[ConnectionTypes.MYSQL][queryKey];

            var comm = _dnCon.CreateCommand();

            if (values != null)
            {
                foreach (var v in values)
                {
                    var p = new MySqlParameter(v.key, MySqlDbType.VarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = v.value
                    };

                    comm.Parameters.Add(p);
                }
            }

            comm.CommandText = query;

            dynamic res = null;

            try
            {
                var reader = comm.ExecuteReader();

                if (returnType == ReturnTypes.List || returnType == ReturnTypes.JsonString)
                {
                    res = new List<Dictionary<string, object>>();
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();

                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader[i] == DBNull.Value ? null : reader[i]);
                        }

                        res.Add(row);
                    }

                    if (returnType == ReturnTypes.JsonString)
                    {
                        reader.Close();
                        CloseConnection();
                        return LitJson.JsonMapper.ToJson(res);
                    }
                }
                else if (returnType == ReturnTypes.DataTable)
                {
                    res = new DataTable();
                    res.Load(reader);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            CloseConnection();

            return res;
        }
        #endregion
    }
}
