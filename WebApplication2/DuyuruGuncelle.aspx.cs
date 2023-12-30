using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["DUYURUID"].ToString());

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();
                dt.DuyuruSec(id);
                TxtDuyuruBaslik.Text = dt.DuyuruSec(id)[0].DUYURUBASLIK;
                TxtDuyuruicerik.Value = dt.DuyuruSec(id)[0].DUYURUICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();
            dt.DuyuruGuncelle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value, id);
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}