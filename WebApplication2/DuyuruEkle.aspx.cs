using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        string DuyuruGonderen;
        protected void Page_Load(object sender, EventArgs e)
        {
            DuyuruGonderen = Session["OGRNUMARA"].ToString();

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();
            dt.DuyuruEkle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value.ToString(), Convert.ToInt32(DuyuruGonderen));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}