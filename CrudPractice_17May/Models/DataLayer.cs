using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CrudPractice_17May.Models
{
    public class DataLayer
    {
        public DataTable Operation(Properties p)
        {
            SqlParameter[] Parameter = new SqlParameter[] {
                new SqlParameter("@Action",p.Action),
                new SqlParameter("@Name",p.Name),
                new SqlParameter("@Email",p.Email),
                new SqlParameter("@Number",p.Number),
                new SqlParameter("@Id",p.Id)
            };
            AdoLayer ado = new AdoLayer();
            DataTable data = ado.Execute("sp_reg", Parameter);
            return data;
        }
    }
}