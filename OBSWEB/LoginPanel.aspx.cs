using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OBSWEB
{
    public partial class LoginPanel : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SiteDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenci WHERE OgrNumara = @p1 and OgrSifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                Session.Add("OgrNumara", TxtKullaniciAdi.Text);
                Response.Redirect("OgrenciDefault.aspx");
            }
            else
            {
                TxtKullaniciSifre.Text = "Hatalı Şifre";
            }
            baglanti.Close();
        }
    }
}