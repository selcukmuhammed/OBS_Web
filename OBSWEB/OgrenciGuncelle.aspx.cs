using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                try
                {
                    id = Convert.ToInt32(Request.QueryString["OgrId"].ToString());
                    TxtOgrId.Text = id.ToString();

                    DataSetTableAdapters.Tbl_OgrenciTableAdapter dt = new DataSetTableAdapters.Tbl_OgrenciTableAdapter();
                    TxtOgrAd.Text = dt.OgrenciSec(id)[0].OgrAd;
                    TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OgrSoyad;
                    TxtOgrTelefon.Text = dt.OgrenciSec(id)[0].OgrTelefon;
                    TxtOgrMail.Text = dt.OgrenciSec(id)[0].OgrMail;
                    TxtOgrSifre.Text = dt.OgrenciSec(id)[0].OgrSifre;
                    TxtOgrFoto.Text = dt.OgrenciSec(id)[0].OgrFotograf;
                }
                catch (Exception)
                {
                    TxtOgrFoto.Text = "Link Girin";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.Tbl_OgrenciTableAdapter dt = new DataSetTableAdapters.Tbl_OgrenciTableAdapter();
            dt.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTelefon.Text, TxtOgrMail.Text, TxtOgrSifre.Text, TxtOgrFoto.Text, Convert.ToInt32(TxtOgrId.Text));
            Response.Redirect("Default.aspx");
        }
    }
}