﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.Tbl_OgrenciTableAdapter dt = new DataSetTableAdapters.Tbl_OgrenciTableAdapter();
            Repeater1.DataSource = dt.OgrenciListesi();
            Repeater1.DataBind();
        }
    }
}