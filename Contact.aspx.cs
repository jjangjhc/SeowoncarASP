using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP
{
    public partial class Contact : Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MetaDescription = "고객센터에서 다양한 방법으로 연결하세요.";

            if (!IsPostBack)
            {
                //포스트백 페이지가 아닐경우 처리
                sendMailNone.Visible = false;
            }
            else
            {
                if (sendMailNone.Visible)
                {
                    return;
                }
                



                MailMessage mail = new MailMessage();
                mail.From = Request["email"];
                mail.To = "help@seowoncar.co.kr";
                mail.Subject = "[서원폐차장] " + Request["name"] + Request["subject"];
                mail.Body = Request["message"];
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1"); //basic authentication
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "help@seowoncar.co.kr"); //set your username here
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "fnsl1rhf1!"); //set your password here

                try
                {
                    //성공 시
                    SmtpMail.SmtpServer = "mw-002.cafe24.com"; //your real server goes here
                    SmtpMail.Send(mail);

                    sendMailNone.Visible = true;
                    sendMail.Visible = false;

                }
                catch
                {
                    //실패 시
                }
            }

        }
    }
}