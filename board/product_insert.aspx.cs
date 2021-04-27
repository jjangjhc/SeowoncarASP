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
    public partial class product_insert : System.Web.UI.Page
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


            }
            else
            {

                //txtMANUFACTURER.Text;

                string sProductID = CCM.fnNewProuductID();
                string sUploadPath = CCM.fnUploadPath(Request.Url.ToString());
                sUploadPath = Path.Combine(sUploadPath, sProductID.Substring(0, 4), sProductID.Substring(4, 2));
                string sID = Session["id"].ToString();



                //insert
                StringBuilder sbQuery = new StringBuilder();
                sbQuery.AppendLine("INSERT INTO [seowoncarasp].[SEOWON_PRODUCT]  ");
                sbQuery.AppendLine("      ( ");
                sbQuery.AppendLine("       [PRODUCTID] ");
                sbQuery.AppendLine("      ,[MANUFACTURER] ");
                sbQuery.AppendLine("      ,[NAME] ");
                sbQuery.AppendLine("      ,[YEAR] ");
                sbQuery.AppendLine("      ,[VIN] ");
                sbQuery.AppendLine("      ,[PARTNUM] ");
                sbQuery.AppendLine("      ,[PRODUCTINFO] ");
                sbQuery.AppendLine("      ,[MOREINFO] ");
                sbQuery.AppendLine("      ,[RETURNINFO] ");
                sbQuery.AppendLine("      ,[SHIPPINGINFO] ");
                sbQuery.AppendLine("      ,[PUBLISHER] ");
                //sbQuery.AppendLine("      ,[POSTINGTIME] ");
                //sbQuery.AppendLine("      ,[LASTMODIFIER] ");
                //sbQuery.AppendLine("      ,[LASTMODIFIEDTIME] ");
                sbQuery.AppendLine("      ) ");
                sbQuery.AppendLine("     VALUES ");
                sbQuery.AppendLine("      ( ");
                sbQuery.AppendLine("       @PRODUCTID");
                sbQuery.AppendLine("      ,@MANUFACTURER");
                sbQuery.AppendLine("      ,@NAME");
                sbQuery.AppendLine("      ,@YEAR");
                sbQuery.AppendLine("      ,@VIN");
                sbQuery.AppendLine("      ,@PARTNUM");
                sbQuery.AppendLine("      ,@PRODUCTINFO");
                sbQuery.AppendLine("      ,@MOREINFO");
                sbQuery.AppendLine("      ,@RETURNINFO");
                sbQuery.AppendLine("      ,@SHIPPINGINFO");
                sbQuery.AppendLine("      ,@PUBLISHER");
                //sbQuery.AppendLine("      ,@POSTINGTIME");
                //sbQuery.AppendLine("      ,@LASTMODIFIER");
                //sbQuery.AppendLine("      ,@LASTMODIFIEDTIME");
                sbQuery.AppendLine("      ) ");

                SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                cmd.Parameters.AddWithValue("@PRODUCTID", sProductID);
                cmd.Parameters.AddWithValue("@MANUFACTURER", txtMANUFACTURER.Text);
                cmd.Parameters.AddWithValue("@NAME", txtNAME.Text);
                cmd.Parameters.AddWithValue("@YEAR", txtYEAR.Text);
                cmd.Parameters.AddWithValue("@VIN", txtVIN.Text);
                cmd.Parameters.AddWithValue("@PARTNUM", txtPARTNUM.Text);
                cmd.Parameters.AddWithValue("@PRODUCTINFO", txtPRODUCTINFO.Text);
                cmd.Parameters.AddWithValue("@MOREINFO", txtMOREINFO.Text);
                cmd.Parameters.AddWithValue("@RETURNINFO", txtRETURNINFO.Text);
                cmd.Parameters.AddWithValue("@SHIPPINGINFO", txtSHIPPINGINFO.Text);
                cmd.Parameters.AddWithValue("@PUBLISHER", sID);
                //cmd.Parameters.AddWithValue("@POSTINGTIME",default);
                //cmd.Parameters.AddWithValue("@LASTMODIFIER",Environment.UserName);
                //cmd.Parameters.AddWithValue("@LASTMODIFIEDTIME",DateTime.Now);



                //파일이 없으면 실패



                //업로드된 파일의 개수는?
                List<FileUpload> listFileUpload = new List<FileUpload>();

                if (FileUpload1.PostedFile.FileName.Length > 0)
                {
                    listFileUpload.Add(FileUpload1);
                }
                if (FileUpload2.PostedFile.FileName.Length > 0)
                {
                    listFileUpload.Add(FileUpload2);
                }
                if (FileUpload3.PostedFile.FileName.Length > 0)
                {
                    listFileUpload.Add(FileUpload3);
                }
                if (FileUpload4.PostedFile.FileName.Length > 0)
                {
                    listFileUpload.Add(FileUpload4);
                }
                if (FileUpload5.PostedFile.FileName.Length > 0)
                {
                    listFileUpload.Add(FileUpload5);
                }


                if (listFileUpload.Count <= 0)
                {
                    return;
                }


                CCM.fnQuerySQL(cmd, "INSERT");

                //파일 업로드
                int i = 0;
                foreach (FileUpload fu in listFileUpload)
                {
                    string sType = fu.PostedFile.FileName;
                    i++;
                    sType = sType.Substring(sType.LastIndexOf("."));
                    string sSavePAth = Path.Combine(sUploadPath, sProductID.Substring(6, 9) + "_" + (i) + sType);

                    DirectoryInfo diUploadPath = new DirectoryInfo(sUploadPath);
                    if (!diUploadPath.Exists) {
                        diUploadPath.Create();
                    }

                    fu.SaveAs(sSavePAth);
                }

                //파일 용량이 크면 처리하기
                int iLength = FileUpload1.PostedFile.ContentLength;
                if (iLength > 4000)
                {

                }


                Session["productid"] = null;
                //입력후 
                Response.Redirect("/board/product_list");
            }
        }
    }
}
