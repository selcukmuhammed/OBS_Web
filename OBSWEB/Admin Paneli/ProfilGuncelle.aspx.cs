using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class ProfilGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtSay1.Text = Request.QueryString["OgrNumara"];

            if (Page.IsPostBack == false)
            {
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TxtSay1.Text = Request.QueryString["OgrNumara"];

            DataSetTableAdapters.Tbl_OgrenciTableAdapter dt = new DataSetTableAdapters.Tbl_OgrenciTableAdapter();
            dt.OgrenciSifreGuncelle(TxtSay2.Text, TxtSay1.Text);
            Response.Redirect("OgrenciDefault.aspx?OgrNumara=" + TxtSay1.Text);
        }
    }
}