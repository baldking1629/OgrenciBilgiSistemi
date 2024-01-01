using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnSifre_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            string ogrMail = dt.OgrenciMail(TxtNumara.Text.ToString())[0].OGRMAIL;

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("obssistem@outlook.com");

                mail.To.Add(ogrMail);     //Please enter the e-mail address to be sent.
                mail.Subject = "Yeni Şifre";


                Random random = new Random();
                int yeniSifre = random.Next(100000, 999999);
                dt.OgrenciSifreGuncelle(yeniSifre.ToString(),TxtNumara.Text.ToString());
                mail.Body = "Yeni şifreniz: " + yeniSifre;

                mail.Priority = MailPriority.Normal;

                //if you want to add attachment add the path of the file here
               // mail.Attachments.Add(new Attachment(""));

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("obssistem@outlook.com", "Obs12345");

                
                smtp.Port = 587;    //this port address is the port served by microsoft services
                smtp.Host = "smtp-mail.outlook.com";
                
                //https://support.microsoft.com/en-us/office/pop-imap-and-smtp-settings-8361e398-8af4-4e97-b147-6c6c4ac95353

                smtp.EnableSsl = true;

                smtp.Send(mail);

                Response.Redirect("Login.aspx");

                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}