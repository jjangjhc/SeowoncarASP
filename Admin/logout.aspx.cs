using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP.Admin
{
    public partial class logout : System.Web.UI.Page
    {
        CommonClassMain CCM = new CommonClassMain();
        string sKEY = "851024";

        protected void Page_Load(object sender, EventArgs e)
        {
            string sRef = string.Empty;
            if (!IsPostBack)
            {
                if (Request.UrlReferrer != null)
                {
                    sRef = Request.UrlReferrer.ToString();
                    if (sRef.ToUpper().Contains("SIGNUP"))
                    {
                        sRef = "/";
                    }
                    lblREF.Text = sRef;


                    Session["id"] = null;
                    Session.Timeout = 30;
                    Session["power"] = null;

                    sRef = lblREF.Text;
                    string sServer = string.Empty;

                    if (sRef.Length > 0)
                    {
                        Response.Redirect(sRef);
                    }
                    else
                    {
                        Response.Redirect("/");
                    }



                }


            }
            else
            {



            }
        }
    }
}