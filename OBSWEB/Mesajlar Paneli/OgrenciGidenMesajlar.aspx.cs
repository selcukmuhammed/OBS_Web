﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class OgrenciGidenMesajlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.Tbl_MesajlarTableAdapter dt = new DataSetTableAdapters.Tbl_MesajlarTableAdapter();
            Repeater1.DataSource = dt.OgrenciGidenKutusu1(Session["OgrNumara"].ToString());
            Repeater1.DataBind();
        }
    }
}