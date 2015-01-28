using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;

namespace LibraryManagementSystem.UI
{
    public partial class ViewBooks : System.Web.UI.Page
    {
        BorrowManager aBorrowManager= new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            string number = Request.QueryString["MemberNumber"];
            booksGridView.DataSource = aBorrowManager.GetSelectedBookList(number);
            booksGridView.DataBind();
        }
    }
}