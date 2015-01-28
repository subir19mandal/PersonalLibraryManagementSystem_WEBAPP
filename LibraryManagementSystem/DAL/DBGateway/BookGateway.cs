using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class BookGateway:Gateway
    {
        public List<Book> GetAll()
        {
            string query = "SELECT * FROM tbl_book;";
            DBSqlConnection=new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand=new SqlCommand(query,DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            List<Book> books=new List<Book>();
            while (DbSqlDataReader.Read())
            {
                Book aBook=new Book();
                aBook.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                aBook.Title = DbSqlDataReader["title"].ToString();
                aBook.Author = DbSqlDataReader["author"].ToString();
                aBook.Publisher = DbSqlDataReader["publisher"].ToString();
                books.Add(aBook);
            }
            DBSqlConnection.Close();
            return books;
        }

        public Book Find(int id)
        {
            string query = "SELECT * FROM tbl_book WHERE id=" + id + ";";
            DBSqlConnection=new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand=new SqlCommand(query,DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            if (DbSqlDataReader.HasRows)
            {
                Book aBook=new Book();
                while (DbSqlDataReader.Read())
                {
                    aBook.Id = Convert.ToInt32(DbSqlDataReader["id"]);
                    aBook.Title = DbSqlDataReader["title"].ToString();
                    aBook.Author = DbSqlDataReader["author"].ToString();
                    aBook.Publisher = DbSqlDataReader["publisher"].ToString();
                }
                DBSqlConnection.Close();
                return aBook;
            }
            DBSqlConnection.Close();
            return null;
        }

        public List<Book> GetSelectedBookList(string number)
        {
            Book aBook;
            List<Book> bookList = new List<Book>();
            string query =
                "SELECT tbl_member.number memberNumber, tbl_book.title bookTitle, tbl_book.id bookId, tbl_book.author author, tbl_book.publisher publisher, tbl_borrow.is_returned isReturned FROM tbl_book JOIN tbl_borrow ON tbl_book.id=tbl_borrow.book_id JOIN tbl_member ON tbl_member.id=tbl_borrow.member_id WHERE tbl_member.number='" + number + "' AND tbl_borrow.is_returned='False'";
            DBSqlConnection=new SqlConnection(ConnectionString);
            DBSqlConnection.Open();
            DbSqlCommand=new SqlCommand(query,DBSqlConnection);
            DbSqlDataReader = DbSqlCommand.ExecuteReader();
            while (DbSqlDataReader.Read())
            {
                aBook = new Book();
                aBook.Id = (int) DbSqlDataReader["bookId"];
                aBook.Title = DbSqlDataReader["bookTitle"].ToString();
                aBook.Author = DbSqlDataReader["author"].ToString();
                aBook.Publisher = DbSqlDataReader["publisher"].ToString();
                
                bookList.Add(aBook);
            }
            DBSqlConnection.Close();
            return bookList;
        }
    }
}