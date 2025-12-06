using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Online_Supermarket.Models
{
        public class Functions
        {
                private SqlConnection _connection;
                private SqlCommand _command;
                private DataTable DataTable;
                private SqlDataAdapter _adapter;
                private string ConStr;
                public Functions()
                {
                        ConStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\huoyi\\OneDrive\\Desktop\\Supermarket\\Online SuperMarket\\Online Supermarket\\App_Data\\SupermarketDb.mdf\";Integrated Security=True";
                        _connection = new SqlConnection(ConStr);
                        _command = new SqlCommand();
                        _command.Connection = _connection;
                }

                public DataTable GetData(string Query)
                {
                        DataTable dt = new DataTable();
                        _adapter = new SqlDataAdapter(Query, ConStr);
                        _adapter.Fill(dt);
                        return dt;
                }

                public int SetData(string Query)
                {
                        int cnt = 0;
                        if (_connection.State == ConnectionState.Closed)
                        {
                                _connection.Open();
                        }
                        _command.CommandText = Query;
                        cnt = _command.ExecuteNonQuery();
                        _connection.Close();
                        return cnt;
                }
        }
}