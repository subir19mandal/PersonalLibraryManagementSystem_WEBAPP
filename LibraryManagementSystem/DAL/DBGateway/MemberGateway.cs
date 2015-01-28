using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class MemberGateway:Gateway
    {
        public Member Find(string number)
        {
            string query = "SELECT * FROM tbl_member WHERE number='" + number + "';";
            DBSqlConnection=new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand=new SqlCommand(query,DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                Member aMember=new Member();
                while (DbSqlDataReader.Read())
                {
                    aMember.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aMember.Number = DbSqlDataReader["number"].ToString();
                }
                DBSqlConnection.Close();
                return aMember;
            }
            else
            {
                DBSqlConnection.Close();
                return null;
            }
            
        }
        public Member Find(int id)
        {
            string query = "SELECT * FROM tbl_member WHERE id='" + id + "';";
            DBSqlConnection = new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                Member aMember = new Member();
                while (DbSqlDataReader.Read())
                {
                    aMember.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aMember.Number = DbSqlDataReader["number"].ToString();
                }
                DBSqlConnection.Close();
                return aMember;
            }
            DBSqlConnection.Close();
            return null;
        }
    }
}