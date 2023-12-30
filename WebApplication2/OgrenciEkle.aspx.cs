//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Windows.Forms;

//namespace WebApplication2
//{
//    public partial class OgrenciEkle : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Button1_Click1(object sender, EventArgs e)
//        {
//            Random random = new Random();
//            int number = random.Next(10000, 99999);
//            if (int.TryParse(TxtOgrTel.Text,out int deger))
//            {
//                DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
//                dt.OgrenciEkle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text, number.ToString());
//                Response.Redirect("Anasayfa.aspx");
//            }
//            else
//            {


//            }

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(10000, 99999);

            // Ad ve soyadı kontrol et
            if (TxtOgrAd.Text.Length <= 0 || TxtOgrSoyad.Text.Length <= 0)
            {
                lblHataMesaji.Text = "Ad ve soyad boş bırakılamaz.";
                lblHataMesaji.Visible = true;
                return;
            }

            // Telefon numarasını kontrol et
            if (TxtOgrTel.Text.Length != 11 || !TxtOgrTel.Text.All(char.IsDigit))
            {
                lblHataMesaji.Text = "Telefon numarası 11 haneli ve sayılardan oluşmalıdır.";
                lblHataMesaji.Visible = true;
                return;
            }

            // Mail adresini kontrol et
            if (!TxtOgrMail.Text.EndsWith("@gmail.com"))
            {
                lblHataMesaji.Text = "Mail adresi @gmail.com ile bitmelidir.";
                lblHataMesaji.Visible = true;
                return;
            }

       
      

            // Hata yoksa bilgileri kaydet
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciEkle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text, number.ToString());
            Response.Redirect("Anasayfa.aspx");
        }

    }
}
