using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OBSWEB
{
    public partial class Istatistikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.DataTable1TableAdapter dt = new DataSetTableAdapters.DataTable1TableAdapter();
            TxtSay1.Text = "Toplam Öğrenci Sayısı : " + dt.Istatistik1().ToString();
            TxtSay2.Text = "Toplam Öğretmen Sayısı : " + dt.Istatistik2().ToString();
            TxtSay3.Text = "Toplam Ders Sayısı : " + dt.Istatistik3().ToString();
            TxtSay4.Text = "Matematik Dersindeki En Başarılı Öğrenciler : " + dt.Istatistik4().ToString();
            TxtSay5.Text = "Fizik Dersindeki En Başarılı Öğrenci : " + dt.Istatistik5().ToString();
            TxtSay6.Text = "Dil Anlatım Dersindeki En Başarılı Öğrenci : " + dt.Istatistik6().ToString();
            TxtSay7.Text = "Kimya Dersindeki En Başarılı Öğrenci : " + dt.Istatistik7().ToString();
            TxtSay8.Text = "Biyoloji Dersindeki En Başarılı Öğrenci : " + dt.Istatistik8().ToString();
            TxtSay9.Text = "Bilgisayar Dersindeki En Başarılı Öğrenci : " + dt.Istatistik9().ToString();
            TxtSay10.Text = "Matematik Dersinin Sınav Not Ortalaması : " + dt.Istatistik10().ToString();
            TxtSay11.Text = "Fizik Dersinin Sınav Not Ortalaması : " + dt.Istatistik11().ToString();
            TxtSay12.Text = "Kimya Dersinin Sınav Not Ortalamsı : " + dt.Istatistik12().ToString();
            TxtSay13.Text = "Biyoloji Dersinin Sınav Not Ortalaması : " + dt.Istatistik13().ToString();
        }
    }
}