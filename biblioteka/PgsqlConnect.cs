using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace biblioteka
{
    public class PgsqlConnect
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; " +
            "Port=5432; Database=bibliodb;" +
            "User Id=postgres;" +
            "Password=123;");
        private DataSet dataSet;

        public DataSet Query(string sql)
        {
            dataSet = new DataSet();
            try
            {
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                add.Fill(dataSet);
                return dataSet;
            }
            catch(Exception Ex)
            {
                return null;
            }
        }
    }
}
