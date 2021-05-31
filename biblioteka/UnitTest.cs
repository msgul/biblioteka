using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace biblioteka
{
    public class UnitTest
    {
        PgsqlConnect pg = new PgsqlConnect();
        DataSet ds;
        string sql;

        public bool check_biblioDB_conection()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; " +
            "Port=5432; Database=bibliodb;" +
            "User Id=postgres;" +
            "Password=123;");
            DataSet dataSet = new DataSet();

            string sql = "select * from users";
            
            try
            {
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                add.Fill(dataSet);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public bool check_item_added(string item_id)
        {
            string sql = "select * from items where id = " + item_id;

            ds = pg.Query(sql);

            if (ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool check_negative_balance(User user)
        {
            if(user.balance < 0)
                return true;
            else
                return false;
        }

    }
}
