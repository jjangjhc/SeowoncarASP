using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP.board
{
    public partial class board_list_check : System.Web.UI.Page
    {

        CommonClassMain CCM = new CommonClassMain();
        public string sReturnValue = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //해당글의 비밀번호를 알 경우

                //로그인 사용자와 같을경우

                //관리자인 경우

                string sSessionID = Session["id"] != null ? Session["id"].ToString() : string.Empty;
                string sSessionPOWER = Session["power"] != null ? Session["power"].ToString() : string.Empty;




                string sID = string.Empty;
                try
                {
                    sID = Request["id"].ToString();
                }
                catch
                {
                    return;
                }

                int iID = 0;
                Int32.TryParse(sID, out iID);


                if (sSessionPOWER.Length > 0)
                {
                    int iSessionPower = Int32.Parse(sSessionPOWER);
                    if (iSessionPower >= 100)
                    {
                        //페이지 이동
                        sReturnValue += string.Format("parent.document.getElementById('hfBOARD_ID').value = '{0}'", iID);
                        sReturnValue =Environment.NewLine + "parent.document.forms[0].submit();";
                        return;

                    }

                }


                string sPassword = Request["password"].ToString();

                StringBuilder sbQuery2 = new StringBuilder();
                sbQuery2.AppendLine(" SELECT USER_ID ");
                sbQuery2.AppendLine("   FROM [seowoncarasp].[SEOWON_BOARD] ");
                sbQuery2.AppendLine("  WHERE BOARD_ID = @BOARD_ID");
                sbQuery2.AppendLine("    AND PASSWORD = @PASSWORD");



                SqlCommand scCmd2 = new SqlCommand(sbQuery2.ToString());
                scCmd2.Parameters.AddWithValue("@BOARD_ID", iID);
                scCmd2.Parameters.AddWithValue("@PASSWORD", sPassword);


                SqlDataReader reader2 = CCM.fnQuerySQL(scCmd2, "SELECT");


                int iCount = 0;
                bool bSameUSER_ID = false;

                while (reader2.Read())
                {
                    iCount++;
                    string sUSER_ID = reader2["USER_ID"].ToString();

                    if (sSessionID.Length > 0)
                    {
                        if (sSessionID.Equals(sUSER_ID))
                        {
                            bSameUSER_ID = true;
                        }
                    }

                }
                reader2.Close();

                if (iCount == 1 && (sPassword.Length>0))
                {
                    bSameUSER_ID = true;
                }


                if (bSameUSER_ID)
                {
                    sReturnValue += string.Format("parent.document.getElementById('hfBOARD_ID').value = '{0}'", iID);
                    sReturnValue = Environment.NewLine + "parent.document.forms[0].submit();";
                }
                else
                {
                   
                    sReturnValue = "$(\"#lblCheckPassword\",opener.document).show();";
                    sReturnValue += "$(\"#lblCheckPassword\",opener.document).val(\"비밀번호가 틀렸습니다.\");";

                    sReturnValue = "parent.document.getElementById('lblCheckPassword').style.display='block';";
                    sReturnValue += "parent.document.getElementById('lblCheckPassword').value=\"비밀번호가 틀렸습니다.\";";
                }







            }
            else
            {

            }


        }
    }
}