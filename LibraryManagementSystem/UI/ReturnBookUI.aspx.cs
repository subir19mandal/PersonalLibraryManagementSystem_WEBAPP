using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class ReturnBookUI : System.Web.UI.Page
    {
        MemberManager aMemberManager = new MemberManager();
        public BorrowManager aBorrowManager = new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showBorrowedBookListButton_Click(object sender, EventArgs e)
        {
            bookDropDownList.DataSource = aBorrowManager.GetSelectedBookList(memberNoTextBox.Text);
            bookDropDownList.DataTextField = "Title";
            bookDropDownList.DataValueField = "Id";
            bookDropDownList.DataBind();
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            string msg;
            Borrow aBorrow = new Borrow();
            Member aMember = aMemberManager.Find(memberNoTextBox.Text);
            if (aMember == null)
            {
                msg = "Not Exists.";
            }
            else
            {
                aBorrow.MemberId = aMember.Id;
                aBorrow.BookId = Convert.ToInt32(bookDropDownList.SelectedValue);
                //aBorrow.IsReturned = true;
                msg = aBorrowManager.Return(aBorrow);
                
            }
            messageLabel.Text = msg;
        }
    }
}