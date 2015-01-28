using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{
    public class BookManager
    {
        BookGateway aBookGateway=new BookGateway();
        public List<Book> GetAll()
        {
            return aBookGateway.GetAll();
        }

        public Book Find(int id)
        {
            return aBookGateway.Find(id);
        }
    }
}