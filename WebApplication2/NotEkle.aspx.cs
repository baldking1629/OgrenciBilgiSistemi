using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotEkle : System.Web.UI.Page
    {
        double sinav1, sinav2, sinav3;

        protected void Page_Load(object sender, EventArgs e)
        {

            int ogrtıd = Convert.ToInt32(Session["OGRTID"]) ;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
                DropDownList1.DataSource = dt.DersListesi();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "DersID";
                DropDownList1.DataBind();

                DataSet1TableAdapters.TBL_OGRENCITableAdapter dt1 = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
                DropDownList2.DataSource = dt1.OgrenciAdSoyad();
                DropDownList2.DataTextField = "OGRADSOYAD";
                DropDownList2.DataValueField = "OGRID";
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double ort;
            
            
            if (!TxtSınav1.Text.All(char.IsDigit) || !TxtSınav2.Text.All(char.IsDigit) || Convert.ToInt32(TxtSınav1.Text) > 100 || Convert.ToInt32(TxtSınav1.Text) < 0
                || Convert.ToInt32(TxtSınav2.Text) > 100 || Convert.ToInt32(TxtSınav2.Text) < 0)
            {
                lblHataMesaji.Text = "Sınav notu geçersiz";
                lblHataMesaji.Visible = true;
                return;
            }
            else
            {
                lblHataMesaji.Visible = false;
            }
            sinav1 = Convert.ToInt32(TxtSınav1.Text);
            sinav2 = Convert.ToInt32(TxtSınav2.Text);
            ort = ((sinav1 * 0.4) + (sinav2 * 0.6));
            bool durum = false;
            if (ort < 50 || sinav2<50)
            {
                durum = false;
                
                

            }
            else if (ort >= 50)
            {
                durum = true;
                
            }
            DataSet1TableAdapters.TBL_NOTLARTableAdapter dt = new DataSet1TableAdapters.TBL_NOTLARTableAdapter();
            dt.NotEkleButsuz(Convert.ToInt32(DropDownList2.SelectedValue) , Convert.ToByte(DropDownList1.SelectedValue) , Convert.ToByte( TxtSınav1.Text), Convert.ToByte(TxtSınav2.Text),Convert.ToDecimal(ort) ,durum);
            Response.Redirect("NotListesi.aspx");
        }
    }
}