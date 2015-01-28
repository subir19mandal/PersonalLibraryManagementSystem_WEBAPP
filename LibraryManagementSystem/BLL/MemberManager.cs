using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{
    public class MemberManager
    {
        MemberGateway aMemberGateway=new MemberGateway();
        public Member Find(string number)
        {
            return aMemberGateway.Find(number);
        }
        public Member Find(int id)
        {
            return aMemberGateway.Find(id);
        }
    }
}