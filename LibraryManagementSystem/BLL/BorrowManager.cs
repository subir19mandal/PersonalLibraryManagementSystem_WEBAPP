using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{
    public class BorrowManager
    {
        MemberManager aMemberManager=new MemberManager();
        BorrowGateway aBorrowGateway=new BorrowGateway();
        BookGateway aBookGateway = new BookGateway();

        public string Borrow(Borrow aBorrow)
        {
            if (aMemberManager.Find(aBorrow.MemberId) == null)
            {
                return "Not Exist";
            }
            aBorrowGateway.Borrow(aBorrow);
            return "Saved";
        }

        public List<Book> GetSelectedBookList(string memberNumber)
        {
            return aBookGateway.GetSelectedBookList(memberNumber);
        }

        public string Return(Borrow aBorrow)
        {
            if (aBorrowGateway.Return(aBorrow) > 0)
            {
                return "Returned";
            }
            else
            {
                return "Error occured";
            }
        }

        public List<BookNotReturne> NotReturnBookList()
        {
            return aBorrowGateway.NotReturnBookList();            
        }
    }
}