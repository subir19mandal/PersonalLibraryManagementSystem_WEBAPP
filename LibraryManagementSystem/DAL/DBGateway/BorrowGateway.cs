using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class BorrowGateway:Gateway
    {
        public void Borrow(Borrow aBorrow)
        {
            string query = "INSERT INTO tbl_borrow VALUES(" + aBorrow.MemberId + "," + aBorrow.BookId + ",'" +
                           aBorrow.IsReturned + "');";
            DBSqlConnection=new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand=new SqlCommand(query,DBSqlConnection);
            DbSqlCommand.ExecuteNonQuery();
            DBSqlConnection.Close();
        }

        public int Return(Borrow aBorrow)
        {
            string query = "UPDATE tbl_borrow SET is_returned='True' WHERE book_id='" + aBorrow.BookId + "'AND member_id='" + aBorrow.MemberId + "'";
            DBSqlConnection = new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DBSqlConnection);
            int rowAffected = DbSqlCommand.ExecuteNonQuery();
            DbSqlCommand.Dispose();
            DBSqlConnection.Close();
            return rowAffected;
        }

        public List<BookNotReturne> NotReturnBookList()
        {
            BookNotReturne aBookNotReturne;
            List<BookNotReturne> bookNotReturnList = new List<BookNotReturne>();
            string query = "SELECT * FROM v_no_of_book_not_return";
              
            DBSqlConnection = new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand = new SqlCommand(query, DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();

            while (DbSqlDataReader.Read())
            {
                aBookNotReturne = new BookNotReturne();
                aBookNotReturne.MemberNumber = DbSqlDataReader["number"].ToString();
                aBookNotReturne.MemberName = DbSqlDataReader["name"].ToString();
                aBookNotReturne.NoOfBookNotReturned = (int)DbSqlDataReader["No_of_books_not_returned"];
                bookNotReturnList.Add(aBookNotReturne);
            }
            DBSqlConnection.Close();
            return bookNotReturnList;
        }
    }
}