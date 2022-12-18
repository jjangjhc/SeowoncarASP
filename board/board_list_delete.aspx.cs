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
    public partial class board_list_delete : System.Web.UI.Page
    {

        CommonClassMain CCM = new CommonClassMain();
        public string sReturnValue = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                
                //관리자 확인(세션)
                // 삭제

                string sSessionID = Session["id"] != null ? Session["id"].ToString() : string.Empty;
                string sSessionPOWER = Session["power"] != null ? Session["power"].ToString() : string.Empty;

                string sPAGE_NO = Request["page_no"] != null ? Request["page_no"].ToString() : "1";




                string sBoard_id = string.Empty;
                try
                {
                    sBoard_id = Request["board_id"].ToString();
                }
                catch
                {
                    return;
                }

                int iID = 0;
                Int32.TryParse(sBoard_id, out iID);


                //해당 내역 삭제

                //delete
                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine("DELETE FROM [seowoncarasp].[SEOWON_BOARD]");
                sbQuery.AppendLine(" WHERE [BOARD_ID] =  @BOARD_ID   ");

                SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                cmd.Parameters.AddWithValue("@BOARD_ID", sBoard_id);

                CCM.fnQuerySQL(cmd, "DELETE");

                

                //페이지 이동
                if (sSessionPOWER.Length > 0)
                {
                    int iSessionPower = Int32.Parse(sSessionPOWER);
                    if (iSessionPower >= 100)
                    {
                        //페이지 이동
                        sReturnValue = $"window.open('board_list?page_no={sPAGE_NO}','_top')";
                        return;

                    }

                }
                else
                {
                    //페이지 이동
                    sReturnValue = $"window.open('board_list','_top');";
                    return;
                }






            }
            else
            {

            }


        }
    }
}