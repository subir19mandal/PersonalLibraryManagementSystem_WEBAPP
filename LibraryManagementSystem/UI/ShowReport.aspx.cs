﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;

namespace LibraryManagementSystem.UI
{
    public partial class ShowReport : System.Web.UI.Page
    {
        BorrowManager aBorrowManager =new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            reportGridView.DataSource = aBorrowManager.NotReturnBookList();
            reportGridView.DataBind();
        }

    }
}