using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class Gateway
    {
        public string ConnectionString =
            WebConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        public SqlConnection DBSqlConnection;
        public SqlCommand DbSqlCommand;
        public SqlDataReader DbSqlDataReader;
    }
}