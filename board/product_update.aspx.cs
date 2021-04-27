using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP.board
{
    public partial class product_update : System.Web.UI.Page
    {
        CommonClassMain CCM = new CommonClassMain();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["power"] == null || Int32.Parse(Session["power"].ToString()) < 10)
                {
                    Response.Redirect("/default");
                }


                //수정값이 들어오면
                if (Session["productid"] != null)
                {
                    //읽어서 뿌려주기
                    string sProductid = Session["productid"].ToString();

                    StringBuilder sbQuery2 = new StringBuilder();
                    sbQuery2.AppendLine(" SELECT [PRODUCTID] ");
                    sbQuery2.AppendLine("       ,[MANUFACTURER] ");
                    sbQuery2.AppendLine("       ,[NAME] ");
                    sbQuery2.AppendLine("       ,[YEAR] ");
                    sbQuery2.AppendLine("       ,[VIN] ");
                    sbQuery2.AppendLine("       ,[PARTNUM] ");
                    sbQuery2.AppendLine("       ,[PRODUCTINFO] ");
                    sbQuery2.AppendLine("       ,[MOREINFO] ");
                    sbQuery2.AppendLine("       ,[RETURNINFO] ");
                    sbQuery2.AppendLine("       ,[SHIPPINGINFO] ");
                    sbQuery2.AppendLine("       ,[PUBLISHER] ");
                    sbQuery2.AppendLine("       ,[POSTINGTIME] ");
                    sbQuery2.AppendLine("       ,[LASTMODIFIER] ");
                    sbQuery2.AppendLine("       ,[LASTMODIFIEDTIME] ");
                    sbQuery2.AppendLine("   FROM [seowoncarasp].[SEOWON_PRODUCT] ");
                    sbQuery2.AppendLine("   WHERE [PRODUCTID] =" + sProductid);


                    SqlCommand scCmd2 = new SqlCommand(sbQuery2.ToString());
                    SqlDataReader reader = CCM.fnQuerySQL(scCmd2, "SELECT");


                    while (reader.Read())
                    {
                        txtMANUFACTURER.Text = reader["MANUFACTURER"].ToString();
                        txtMOREINFO.Text = reader["MOREINFO"].ToString();
                        txtNAME.Text = reader["NAME"].ToString();
                        txtPARTNUM.Text = reader["PARTNUM"].ToString();
                        txtPRODUCTID.Text = reader["PRODUCTID"].ToString();
                        txtPRODUCTINFO.Text = reader["PRODUCTINFO"].ToString();
                        txtRETURNINFO.Text = reader["RETURNINFO"].ToString();
                        txtSHIPPINGINFO.Text = reader["SHIPPINGINFO"].ToString();
                        txtVIN.Text = reader["VIN"].ToString();
                        txtYEAR.Text = reader["YEAR"].ToString();
                        txtPUBLISHER.Text = Session["id"].ToString();

                        string sPath = CCM.fnUploadPath(Request.Url.ToString());
                        Image1.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text, 0);
                        Image2.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text, 1);
                        Image3.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text, 2);
                        Image4.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text, 3);
                        Image5.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text, 4);

                        Image1.CssClass = "image-width100";
                        Image2.CssClass = "image-width100";
                        Image3.CssClass = "image-width100";
                        Image4.CssClass = "image-width100";
                        Image5.CssClass = "image-width100";
                    }
                    reader.Close();



                }

            }
            else
            {

                //update
                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine("UPDATE [seowoncarasp].[SEOWON_PRODUCT]  ");
                sbQuery.AppendLine("   SET ");
                sbQuery.AppendLine("       [MANUFACTURER] = @MANUFACTURER ");
                sbQuery.AppendLine("      ,[NAME] = @NAME ");
                sbQuery.AppendLine("      ,[YEAR] = @YEAR ");
                sbQuery.AppendLine("      ,[VIN] = @VIN ");
                sbQuery.AppendLine("      ,[PARTNUM] = @PARTNUM ");
                sbQuery.AppendLine("      ,[PRODUCTINFO] = @PRODUCTINFO ");
                sbQuery.AppendLine("      ,[MOREINFO] = @MOREINFO ");
                sbQuery.AppendLine("      ,[RETURNINFO] = @RETURNINFO ");
                sbQuery.AppendLine("      ,[SHIPPINGINFO] = @SHIPPINGINFO ");
                sbQuery.AppendLine("      ,[LASTMODIFIEDTIME] = SYSDATETIME() ");
                sbQuery.AppendLine("      ,[LASTMODIFIER] = @LASTMODIFIER ");
                sbQuery.AppendLine(" WHERE [PRODUCTID] = @PRODUCTID    ");

                SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                cmd.Parameters.AddWithValue("@PRODUCTID", Session["productid"].ToString());
                cmd.Parameters.AddWithValue("@MANUFACTURER", txtMANUFACTURER.Text);
                cmd.Parameters.AddWithValue("@NAME", txtNAME.Text);
                cmd.Parameters.AddWithValue("@YEAR", txtYEAR.Text);
                cmd.Parameters.AddWithValue("@VIN", txtVIN.Text);
                cmd.Parameters.AddWithValue("@PARTNUM", txtPARTNUM.Text);
                cmd.Parameters.AddWithValue("@PRODUCTINFO", txtPRODUCTINFO.Text);
                cmd.Parameters.AddWithValue("@MOREINFO", txtMOREINFO.Text);
                cmd.Parameters.AddWithValue("@RETURNINFO", txtRETURNINFO.Text);
                cmd.Parameters.AddWithValue("@SHIPPINGINFO", txtSHIPPINGINFO.Text);
                cmd.Parameters.AddWithValue("@LASTMODIFIER", txtPUBLISHER.Text);

                CCM.fnQuerySQL(cmd, "UPDATE");


                Session["productid"] = null;
                //입력후 
                Response.Redirect("/board/product_list");


            }



        }
    }
}
