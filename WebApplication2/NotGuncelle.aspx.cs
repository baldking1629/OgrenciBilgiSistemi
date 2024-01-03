using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotGuncelle : System.Web.UI.Page
    {
        double sinav1, sinav2, sinav3;
        double ort;
        bool durum;
        int nid,ogrid,dersid;
        protected void Page_Load(object sender, EventArgs e)
        {

            
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());

            if (Page.IsPostBack == false)
            {

                
                
                TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADSOYAD;
                TxtDersAd.Text = dt.NotGetir2(nid)[0].DERSAD;
                TxtOgrDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString();
                TxtOgrSınav1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString();
                TxtOgrSınav2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString();
                TxtOgrSınav3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString();
                TxtOgrOrt.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString();

                if (TxtOgrDurum.Text == "True")
                {
                    TxtOgrSınav3.Enabled = false;
                }
            }
            ogrid = dt.NotGetir2(nid)[0].OGRENCIID;
            dersid = Convert.ToInt32(dt.NotGetir2(nid)[0].DERSNID);
            TxtOgrid.Text = ogrid.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            if ( !TxtOgrSınav3.Text.All(char.IsDigit)|| Convert.ToInt32(TxtOgrSınav3.Text) > 100 || Convert.ToInt32(TxtOgrSınav3.Text) < 0)
            {
                lblHataMesaji.Text = "Sınav notu geçersiz";
                lblHataMesaji.Visible = true;
                return;
            }
            else
            {
                lblHataMesaji.Visible = false;
            }
            sinav1 = Convert.ToInt32(TxtOgrSınav1.Text);
            sinav2 = Convert.ToInt32(TxtOgrSınav2.Text);
            sinav3 = Convert.ToInt32(TxtOgrSınav3.Text);
            ort = ((sinav1*0.4) + (sinav3*0.6)) ;
            TxtOgrOrt.Text = ort.ToString("0.00");
            if (ort < 50 || sinav3<50)
            {

                TxtOgrDurum.Text = "Kaldı";
                durum = false;
            }
            else if (ort >= 50)
            {
                TxtOgrDurum.Text = "Geçti";
                durum = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
            
            if (!TxtOgrSınav3.Text.All(char.IsDigit) || Convert.ToInt32(TxtOgrSınav3.Text) > 100 || Convert.ToInt32(TxtOgrSınav3.Text) < 0)
            {
                lblHataMesaji.Text = "Sınav notu geçersiz";
                lblHataMesaji.Visible = true;
                return;
            }
            else
            {
                lblHataMesaji.Visible=false;
            }
            sinav3 = Convert.ToInt32(TxtOgrSınav3.Text);
            sinav1 = Convert.ToInt32(TxtOgrSınav1.Text);

            ort = ((sinav1 * 0.4) + (sinav3 * 0.6));
            TxtOgrOrt.Text = ort.ToString("0.00");
            if (ort < 50 || sinav3 < 50)
            {

                TxtOgrDurum.Text = "Kaldı";
                durum = false;
            }
            else if (ort >= 50)
            {
                TxtOgrDurum.Text = "Geçti";
                durum = true;
            }

            DataSet1TableAdapters.TBL_NOTLARTableAdapter dt = new DataSet1TableAdapters.TBL_NOTLARTableAdapter();
            dt.NotEkleBut(Convert.ToByte(sinav3),Convert.ToDecimal(ort),durum,nid,ogrid,Convert.ToByte(dersid));
            Response.Redirect("NotListesi.aspx");
        }
    }
}