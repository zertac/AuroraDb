using System;
using System.Collections.Generic;
using System.Data;
using AuroraDb.DataClasses;
using AuroraDb.enums;
using Oracle.DataAccess.Client;

namespace AuroraDb.Connectors
{
    internal class AOracleConnector
    {
        private OracleConnection _dnCon;

        public AOracleConnector(string cnnStr = "")
        {
            OpenConnection(cnnStr);
        }

        ~AOracleConnector()
        {
            CloseConnection();
        }

        private void OpenConnection(string cnnStr)
        {
            try
            {
                _dnCon = new OracleConnection(cnnStr);
                if (_dnCon.State == ConnectionState.Closed) _dnCon.Open();
            }
            catch (OracleException e)
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
            var query = DataQueries.Queries[ConnectionTypes.ORACLE][queryKey];

            var comm = _dnCon.CreateCommand();
            var txn = _dnCon.BeginTransaction(IsolationLevel.ReadCommitted);
            comm.Transaction = txn;
            comm.BindByName = true;


            if (values != null)
            {
                foreach (var v in values)
                {
                    var p = new OracleParameter(v.key, OracleDbType.Varchar2)
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
                txn.Commit();

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
            catch (OracleException ex)
            {
                throw ex;
            }
            CloseConnection();

            return res;
        }
        #endregion
    }
}