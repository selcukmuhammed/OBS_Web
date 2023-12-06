﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class NotlarListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.OGRNOTLARTableAdapter dt = new DataSetTableAdapters.OGRNOTLARTableAdapter();
            Repeater1.DataSource = dt.NotlariGetir();
            Repeater1.DataBind();
        }
    }
}