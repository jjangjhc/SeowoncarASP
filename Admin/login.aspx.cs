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
    public partial class login : System.Web.UI.Page
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
                        sRef = "/default";
                    }
                    lblREF.Text = sRef;

                }

                
            }
            else
            {

                lblID.Visible = false;
                lblPW.Visible = false;

                //아이디 //비밀번호 확인

                string sID = txtID.Text;
                string sPW = txtPW.Text;
                bool bLogin = false;

                StringBuilder sbQuerySelect = new StringBuilder();
                sbQuerySelect.AppendLine("SELECT [PASSWORD],[NAME],[POWER] ");
                sbQuerySelect.AppendLine(" FROM [seowoncarasp].[SEOWON_USER] ");
                sbQuerySelect.AppendLine("WHERE [ID] = '" + sID + "' ");

                SqlCommand scCmd = new SqlCommand(sbQuerySelect.ToString());
                SqlDataReader reader = CCM.fnQuerySQL(scCmd, "SELECT");

                string sReturnPW = string.Empty;
                int iPower = 0;
                string sName = string.Empty;

                while (reader.Read())
                {
                    sReturnPW = reader["PASSWORD"].ToString();
                    sName = reader["NAME"].ToString();
                    sPW = CCM.fnAESEncrypt128(sPW,sKEY);

                    iPower = Int32.Parse(reader["POWER"].ToString());

                    if (sPW.Equals(sReturnPW))
                    {
                        bLogin = true;
                    }
                    else
                    {
                        lblPW.Text = "비밀번호가 틀립니다.";
                        lblPW.Visible = true;

                    }
                }
                reader.Close();

                if (sReturnPW.Length <= 0)
                {
                    lblID.Text = "해당하는 아이디가 존재하지 않습니다.";
                    lblID.Visible = true;
                }

                //이전 페이지로 이동 아이디와 비밀번호가 확인되면
                //세션등록 및 이동
                Session["id"] = sID;
                Session.Timeout = 30;
                Session["power"] = iPower;
                


                if (bLogin)
                {
                    sRef = lblREF.Text;
                    string sServer = string.Empty;

                    if (sRef.Length > 0)
                    {
                        Response.Redirect(sRef);
                    }
                    else
                    {
                        Response.Redirect("/default");
                    }


                    return;
                }






            }
        }
    }
}