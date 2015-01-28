using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.DAL.DAO
{
    public class BookNotReturne
    {
        public string MemberNumber { set; get; }
        public string MemberName { set; get; }
        public int NoOfBookNotReturned { set; get; }
    }
}