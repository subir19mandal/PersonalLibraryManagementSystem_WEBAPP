using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.DAL.DAO
{
    public class Borrow
    {
        public int Id { set; get; }
        public int MemberId { set; get; }
        public int BookId { set; get; }
        public bool IsReturned { set; get; }
    }
}