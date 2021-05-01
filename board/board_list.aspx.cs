using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace SeowoncarASP.board
{
    public partial class board_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CommonClassMain CCM = new CommonClassMain();

            if (!IsPostBack)
            {
                secContentBody.Visible = false;

                StringBuilder sbQuery2 = new StringBuilder();
                sbQuery2.AppendLine(" SELECT [BOARD_ID] ");
                sbQuery2.AppendLine("       ,[CATEGORY] ");
                sbQuery2.AppendLine("       ,[USER_ID] ");
                sbQuery2.AppendLine("       ,[TITLE] ");
                sbQuery2.AppendLine("       ,[CONTENT_BOARD] ");
                sbQuery2.AppendLine("       ,[REGDATE] ");
                sbQuery2.AppendLine("       ,[READNUM] ");
                sbQuery2.AppendLine("       ,[RECOMMEND] ");
                sbQuery2.AppendLine("   FROM [seowoncarasp].[SEOWON_BOARD] ");
                sbQuery2.AppendLine("   ORDER BY [BOARD_ID] DESC ");

                
                SqlCommand scCmd2 = new SqlCommand(sbQuery2.ToString());
                SqlDataReader reader2 = CCM.fnQuerySQL(scCmd2, "SELECT");

                XmlDocument xDoc = new XmlDocument();
                XmlDocument xDocTbody = new XmlDocument();

                // < div class="row" id="divProuduct" runat="server">
                XmlElement xeDivRow = xDoc.CreateElement("div");
                XmlAttribute xaClassRow = xDoc.CreateAttribute("class");
                xaClassRow.Value = "row";
                xeDivRow.Attributes.Append(xaClassRow);
                xDoc.AppendChild(xeDivRow);

                XmlElement xeTBody = xDocTbody.CreateElement("tbody");
                xDocTbody.AppendChild(xeTBody);


                while (reader2.Read())
                {
                    string sBOARD_ID = reader2["BOARD_ID"].ToString();
                    string sCATEGORY = reader2["CATEGORY"].ToString();
                    string sUSER_ID = reader2["USER_ID"].ToString();
                    string sTITLE = reader2["TITLE"].ToString();
                    string sCONTENT_BOARD = reader2["CONTENT_BOARD"].ToString();
                    string sREGDATE = reader2["REGDATE"].ToString();
                    string sREADNUM = reader2["READNUM"].ToString();
                    string sRECOMMEND = reader2["RECOMMEND"].ToString();

                    //테이블에 넣기
                    XmlElement xeTR = xDocTbody.CreateElement("tr");

                    XmlElement xeTD1 = xDocTbody.CreateElement("td");
                    XmlElement xeTD2 = xDocTbody.CreateElement("td");
                    XmlElement xeTD3 = xDocTbody.CreateElement("td");
                    XmlElement xeTD4 = xDocTbody.CreateElement("td");
                    XmlElement xeTD5 = xDocTbody.CreateElement("td");
                    XmlElement xeTD6 = xDocTbody.CreateElement("td");

                    xeTD1.InnerText = sBOARD_ID;
                    xeTD2.InnerXml = string.Format("<a href=\"javascript:fnBoardInsert('{0}')\">{1}</a>", sBOARD_ID, sTITLE);
                    xeTD3.InnerText = sUSER_ID;
                    xeTD4.InnerText = sREGDATE;
                    xeTD5.InnerText = sREADNUM;
                    xeTD6.InnerText = sRECOMMEND;

                    xeTR.AppendChild(xeTD1);
                    xeTR.AppendChild(xeTD2);
                    xeTR.AppendChild(xeTD3);
                    xeTR.AppendChild(xeTD4);
                    xeTR.AppendChild(xeTD5);
                    xeTR.AppendChild(xeTD6);

                    xeTBody.AppendChild(xeTR);


                }
                reader2.Close();

                StringBuilder sbTR = new StringBuilder();

                foreach (XmlNode xn in xDocTbody.ChildNodes[0].ChildNodes)
                {
                    sbTR.AppendLine(xn.OuterXml);
                }

                tbody.InnerHtml = sbTR.ToString();

                
            }
            else
            {
                string sBOARD_ID = Request["hfBOARD_ID"].ToString(); 



                secContentBody.Visible = true;


                //조회수 증가
                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine(" UPDATE[seowoncarasp].[SEOWON_BOARD] ");
                sbQuery.AppendLine(" SET[READNUM] = [READNUM] + 1 ");
                sbQuery.AppendLine(string.Format("  WHERE [BOARD_ID] = {0} ", sBOARD_ID));

                SqlCommand scCmd = new SqlCommand(sbQuery.ToString());
                SqlDataReader reader1 = CCM.fnQuerySQL(scCmd, "UPDATE");





                //

                StringBuilder sbQuery2 = new StringBuilder();
                sbQuery2.AppendLine(" SELECT [BOARD_ID] ");
                sbQuery2.AppendLine("       ,[CATEGORY] ");
                sbQuery2.AppendLine("       ,[USER_ID] ");
                sbQuery2.AppendLine("       ,[TITLE] ");
                sbQuery2.AppendLine("       ,[CONTENT_BOARD] ");
                sbQuery2.AppendLine("       ,[REGDATE] ");
                sbQuery2.AppendLine("       ,[READNUM] ");
                sbQuery2.AppendLine("       ,[RECOMMEND] ");
                sbQuery2.AppendLine("   FROM [seowoncarasp].[SEOWON_BOARD] ");
                sbQuery2.AppendLine(string.Format("  WHERE [BOARD_ID] = {0} ", sBOARD_ID));
                


                SqlCommand scCmd2 = new SqlCommand(sbQuery2.ToString());
                SqlDataReader reader2 = CCM.fnQuerySQL(scCmd2, "SELECT");


                while (reader2.Read())
                {
                    
                    string sCATEGORY = reader2["CATEGORY"].ToString();
                    string sUSER_ID = reader2["USER_ID"].ToString();
                    string sTITLE = reader2["TITLE"].ToString();
                    string sCONTENT_BOARD = reader2["CONTENT_BOARD"].ToString();
                    string sREGDATE = reader2["REGDATE"].ToString();
                    string sREADNUM = reader2["READNUM"].ToString();
                    string sRECOMMEND = reader2["RECOMMEND"].ToString();

                    txtTITLE.Text = sTITLE;
                    txtCONTENT_BOARD.Text = sCONTENT_BOARD;
                    txtUSER_ID.Text = sUSER_ID;


                }
                reader2.Close();

                


            }
        }

    }
}