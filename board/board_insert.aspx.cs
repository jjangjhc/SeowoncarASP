using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP.board
{
    public partial class board_insert : System.Web.UI.Page
    {
        CommonClassMain CCM = new CommonClassMain();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    txtUSER_ID.Text = Session["id"].ToString();
                    txtUSER_ID.ReadOnly = true;
                    divPASS1.Visible = false;
                    divPASS2.Visible = false;
                }
            }
            else
            {
                string sUSER_ID = txtUSER_ID.Text;
                string sTITLE = txtTITLE.Text;
                string sCONTENT_BOARD = txtCONTENT_BOARD.Text;
                string sPASSWORD = txtPASSWORD.Text;
                string sPASSWORD2 = txtPASSWORD2.Text;


                if (!sPASSWORD.Equals(sPASSWORD2)){

                    lblPASSWORD_ERROR.Text = "두 개의 비밀번호가 다릅니다. 다시 입력해주세요.";
                    return;
                }

                //insert
                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine("INSERT INTO [seowoncarasp].[SEOWON_BOARD]  ");
                sbQuery.AppendLine("      ( ");
                sbQuery.AppendLine("       [USER_ID] ");
                sbQuery.AppendLine("      ,[TITLE] ");
                sbQuery.AppendLine("      ,[CONTENT_BOARD] ");
                sbQuery.AppendLine("      ,[PASSWORD] ");
                sbQuery.AppendLine("      ) ");
                sbQuery.AppendLine("     VALUES ");
                sbQuery.AppendLine("      ( ");
                sbQuery.AppendLine("       @USER_ID");
                sbQuery.AppendLine("      ,@TITLE");
                sbQuery.AppendLine("      ,@CONTENT_BOARD");
                sbQuery.AppendLine("      ,@PASSWORD");
                sbQuery.AppendLine("      ) ");

                SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                cmd.Parameters.AddWithValue("@USER_ID", sUSER_ID);
                cmd.Parameters.AddWithValue("@TITLE", sTITLE);
                cmd.Parameters.AddWithValue("@CONTENT_BOARD", sCONTENT_BOARD);
                cmd.Parameters.AddWithValue("@PASSWORD", sPASSWORD);

                CCM.fnQuerySQL(cmd, "INSERT");

                Response.Redirect("/board/board_list");



            }

        }
    }
}