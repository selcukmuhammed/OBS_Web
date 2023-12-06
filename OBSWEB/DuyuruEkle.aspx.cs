using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                DataSetTableAdapters.Tbl_OgretmenTableAdapter dt = new DataSetTableAdapters.Tbl_OgretmenTableAdapter();
                DropDownList1.DataSource = dt.OgretmenListesi();
                DropDownList1.DataTextField = "OgrtAdSoyad";
                DropDownList1.DataValueField = "OgrtId";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.Tbl_DuyurularTableAdapter dt = new DataSetTableAdapters.Tbl_DuyurularTableAdapter();
            dt.DuyuruEkle(TxtDuyuruBaslik.Text, TextArea1.Value.ToString(), Convert.ToInt32(DropDownList1.SelectedValue));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}