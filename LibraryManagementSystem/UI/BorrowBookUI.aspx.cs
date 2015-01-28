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
    public partial class BorrowBookUI : System.Web.UI.Page
    {
        BookManager aBookManager=new BookManager();
        MemberManager aMemberManager=new MemberManager();
        BorrowManager aBorrowManager=new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bookDropDownList.DataSource = aBookManager.GetAll();
                bookDropDownList.DataTextField = "Title";
                bookDropDownList.DataValueField = "Id";
                bookDropDownList.DataBind();
            }
        }

        protected void bookDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book aBook = aBookManager.Find(Convert.ToInt32(bookDropDownList.SelectedValue));
            authorTextBox.Text = aBook.Author;
            publisherTextBox.Text = aBook.Publisher;
        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            Borrow aBorrow=new Borrow();
            Member aMember = aMemberManager.Find(memberNoTextBox.Text);
            if (aMember == null) messageLabel.Text = "Not Exist.";
            else
            {
                aBorrow.MemberId = aMember.Id;
                aBorrow.BookId = Convert.ToInt32(bookDropDownList.SelectedValue);
                aBorrow.IsReturned = false;
                string msg = aBorrowManager.Borrow(aBorrow);
                messageLabel.Text = msg;
            }
        }
    }
}