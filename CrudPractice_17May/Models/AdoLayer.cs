using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CrudPractice_17May.Models
{
    public class AdoLayer
    {
        SqlConnection con;
        public AdoLayer()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        }
        public DataTable Execute(string Procedure, SqlParameter[] Parameter)
        {
            SqlCommand command = new SqlCommand(Procedure,con);
            command.CommandType = CommandType.StoredProcedure;
            foreach(SqlParameter Parm in Parameter)
            {
                command.Parameters.Add(Parm);
            }
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            return data;
        }
    }
}