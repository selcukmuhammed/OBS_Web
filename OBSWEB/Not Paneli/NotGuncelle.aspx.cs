using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class NotGuncelle : System.Web.UI.Page
    {
        int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                nid = Convert.ToInt32(Request.QueryString["NotId"].ToString());

                DataSetTableAdapters.OGRNOTLARTableAdapter dt = new DataSetTableAdapters.OGRNOTLARTableAdapter();
                TxtOgrId.Text = dt.NotGetir2(nid)[0].OgrNId.ToString();
                TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADSOYAD;
                TxtDersAdı.Text = dt.NotGetir2(nid)[0].DersAd;
                TxtSınav1.Text = dt.NotGetir2(nid)[0].Sinav1.ToString();
                TxtSınav2.Text = dt.NotGetir2(nid)[0].Sinav2.ToString();
                TxtSınav3.Text = dt.NotGetir2(nid)[0].Sinav3.ToString();
                TxtOrtalama.Text = dt.NotGetir2(nid)[0].Ortalama.ToString();
                TxtDurum.Text = dt.NotGetir2(nid)[0].Durum.ToString();
            }
        }

        protected void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3;
            double ortalama;

            sinav1 = Convert.ToInt32(TxtSınav1.Text);
            sinav2 = Convert.ToInt32(TxtSınav2.Text);
            sinav3 = Convert.ToInt32(TxtSınav3.Text);
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            TxtOrtalama.Text = ortalama.ToString("0.00");
            if(ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NotId"].ToString());

            DataSetTableAdapters.OGRNOTLARTableAdapter dt = new DataSetTableAdapters.OGRNOTLARTableAdapter();
            dt.NotGuncelle(byte.Parse(TxtSınav1.Text), byte.Parse(TxtSınav2.Text), byte.Parse(TxtSınav3.Text), decimal.Parse(TxtOrtalama.Text), bool.Parse(TxtDurum.Text), nid);
            Response.Redirect("NotlarListesi.aspx");
        }
    }
}