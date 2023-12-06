using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class DersGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                id = Convert.ToInt32(Request.QueryString["DersId"].ToString());
                DataSetTableAdapters.Tbl_DerslerTableAdapter dt = new DataSetTableAdapters.Tbl_DerslerTableAdapter();
                TxtDersId.Text = id.ToString();
                TxtDersAd.Text = dt.DersGetir(id)[0].DersAd;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.Tbl_DerslerTableAdapter dt = new DataSetTableAdapters.Tbl_DerslerTableAdapter();
            dt.DersGuncelle(TxtDersAd.Text, Convert.ToInt32(TxtDersId.Text));
            Response.Redirect("DersListesi.aspx");
        }
    }
}