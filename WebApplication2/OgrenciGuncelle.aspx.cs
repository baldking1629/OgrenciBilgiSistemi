using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());

            if (Page.IsPostBack == false)
            {
                try
                {
                    //TxtOgrid.Text = id.ToString();
                    DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
                    TxtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
                    TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                    TxtOgrTel.Text = dt.OgrenciSec(id)[0].OGRTEL;
                    TxtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                    TxtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;

                }
                catch (Exception)
                {
                   
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
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
            dt.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text, id);
            Response.Redirect("Anasayfa.aspx");
        }
    }
}