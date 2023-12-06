using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class OgrenciDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtSay1.Text = Session["OgrNumara"].ToString();

            DataSetTableAdapters.Tbl_OgrenciTableAdapter dt = new DataSetTableAdapters.Tbl_OgrenciTableAdapter();
            TxtSay2.Text = "Ad Soyad : " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrAd + " " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrSoyad;
            TxtSay3.Text = "Telefon : " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrTelefon;
            TxtSay4.Text = "Mail Adresi : " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrMail;
            TxtSay5.Text = "Şifre : " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrSifre;
            TxtSay6.Text = "Cinsiyet : " + dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrCinsiyet;
            TxtSay7.Text = dt.OgrenciPaneliGetir(TxtSay1.Text)[0].OgrFotograf;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilGuncelle.aspx?OgrNumara=" + TxtSay1.Text);
        }
    }
}