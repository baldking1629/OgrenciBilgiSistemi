using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciGuncelle2 : System.Web.UI.Page
    {
        string ad, soyad;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtNumara.Text = Request.QueryString["NUMARA"];
            //id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            ad = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRAD;
            soyad = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRSOYAD;
            if (Page.IsPostBack == false)
            {
                
                
                TxtAdSoyad.Text = ad + " " + soyad;
                TxtMail.Text = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRMAIL;
                TxtSifre.Text = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRSIFRE;
                TxtTelefon.Text = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRTEL;
            }
            id = dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRID;


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            if (TxtTelefon.Text.Length != 11 || !TxtTelefon.Text.All(char.IsDigit))
            {
                lblHataMesaji.Text = "Telefon numarası 11 haneli ve sayılardan oluşmalıdır.";
                lblHataMesaji.Visible = true;
                return;
            }

            // Mail adresini kontrol et
            if (!TxtMail.Text.EndsWith("@gmail.com"))
            {
                lblHataMesaji.Text = "Mail adresi @gmail.com ile bitmelidir.";
                lblHataMesaji.Visible = true;
                return;
            }
            dt.OgrenciGuncelle(ad, soyad, TxtTelefon.Text, TxtMail.Text, TxtSifre.Text, id);


            Response.Redirect("OgrenciDefault.aspx?Numara=" + TxtNumara.Text);
        }
    }
}