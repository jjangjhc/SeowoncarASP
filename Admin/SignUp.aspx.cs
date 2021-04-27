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
    public partial class SignUp : System.Web.UI.Page
    {
        CommonClassMain CCM = new CommonClassMain();
        string sKEY = "851024";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
            else
            {
                string sID = txtID.Text;
                string sPW1 = txtPW1.Text;
                string sPW2 = txtPW2.Text;
                string sPW = string.Empty;
                string sEMAIL = txtEMAIL.Text;
                string sADDRESS = txtADDRESS.Text;
                string sPHONE = txtPHONE.Text;
                string sName = txtName.Text;
                string sIP = Request.UserHostAddress;

                bool bValidation = true;

                lblID.Visible = false;
                lblPW.Visible = false;

                //유효성검사
                if (sID.Length <= 7)
                {
                    bValidation = false;
                    lblID.Text = "아이디는 8자 이상으로 가입 바랍니다.";
                    lblID.Visible = true;
                }

                if (!sPW1.Equals(sPW2))
                {
                    bValidation = false;
                    lblPW.Text = "비밀 번호가 일치하지 않습니다.";
                    lblPW.Visible = true;
                }else if(sPW1.Length <= 7)
                {
                    bValidation = false;
                    lblPW.Text = "비밀번호는 8자 이상으로 가입 바랍니다.";
                    lblPW.Visible = true;
                }

                //아이디 검색해서 개수가 몇갠가 확인하기

                StringBuilder sbQuerySelect = new StringBuilder();
                sbQuerySelect.AppendLine("SELECT count([ID]) as count ");
                sbQuerySelect.AppendLine(" FROM [seowoncarasp].[SEOWON_USER] ");
                sbQuerySelect.AppendLine("WHERE [ID] = '" + sID + "' ");

                SqlCommand scCmd = new SqlCommand(sbQuerySelect.ToString());
                SqlDataReader reader = CCM.fnQuerySQL(scCmd, "SELECT");


                while (reader.Read())
                {
                    int i = Int32.Parse(reader["count"].ToString());
                    if (i >= 1)
                    {
                        bValidation = false;
                        lblID.Text = "이미 등록된 아이디 입니다.";
                        lblID.Visible = true;
                    }                    
                }
                reader.Close();

                if(bValidation == false)
                {
                    txtID.Text = sID;
                    txtADDRESS.Text = sADDRESS;
                    txtEMAIL.Text = sEMAIL;
                    txtName.Text = sName;
                    txtPHONE.Text = sPHONE;
                    txtPW1.Text = sPW1;
                    txtPW2.Text = sPW2;
                    return;
                }


                //insert

                sPW = CCM.fnAESEncrypt128(sPW1, sKEY);

                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine("	INSERT INTO[seowoncarasp].[SEOWON_USER]   ");
                sbQuery.AppendLine("        (                                     ");
                sbQuery.AppendLine("				 [ID]                         ");
                sbQuery.AppendLine("                ,[PASSWORD]                   ");
                sbQuery.AppendLine("                ,[EMAIL]                      ");
                sbQuery.AppendLine("                ,[ADDRESS]                    ");
                sbQuery.AppendLine("                ,[PHONE]                      ");
                sbQuery.AppendLine("                ,[NAME]                       ");
                sbQuery.AppendLine("                ,[IPADDRESS]                  ");
                sbQuery.AppendLine("                ,[POWER]                  ");
                sbQuery.AppendLine("		)                                     ");
                sbQuery.AppendLine("     VALUES                                   ");
                sbQuery.AppendLine("	    (                                     ");
                sbQuery.AppendLine("                 @ID                          ");
                sbQuery.AppendLine("                ,@PASSWORD                    ");
                sbQuery.AppendLine("                ,@EMAIL                       ");
                sbQuery.AppendLine("                ,@ADDRESS                     ");
                sbQuery.AppendLine("                ,@PHONE                       ");
                sbQuery.AppendLine("                ,@NAME                        ");
                sbQuery.AppendLine("                ,@IPADDRESS                   ");
                sbQuery.AppendLine("                ,@POWER                   ");
                sbQuery.AppendLine("		)                                     ");

                SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                cmd.Parameters.AddWithValue("@ID", sID);
                cmd.Parameters.AddWithValue("@PASSWORD", sPW);
                cmd.Parameters.AddWithValue("@EMAIL", sEMAIL);
                cmd.Parameters.AddWithValue("@ADDRESS", sADDRESS);
                cmd.Parameters.AddWithValue("@PHONE", sPHONE);
                cmd.Parameters.AddWithValue("@NAME", sName);
                cmd.Parameters.AddWithValue("@IPADDRESS", sIP);
                cmd.Parameters.AddWithValue("@POWER", 5);

                CCM.fnQuerySQL(cmd, "INSERT");

                Response.Redirect("/admin/login");

            }

        }
    }
}
