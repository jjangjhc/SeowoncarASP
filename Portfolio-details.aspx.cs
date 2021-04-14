using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP
{
    public partial class Portfolio_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonClassMain ccm = new CommonClassMain();

            if (!IsPostBack)
            {

                string s_productid = Request["productid"];  //Get

                if (s_productid == null)
                {
                    //s_productid = "202104062250123";
                    return;
                }

                // GET 받기 //
                // String test2 = Request.QueryString["test2"] //Get

                // POST 받기 //
                // String test1 = Request.Form["test1"]; //Post

                // GET & POST 구분 없이 받기 //
                // String test2 = Request["test2"] //Get  


                try
                {


                    StringBuilder sbQuery = new StringBuilder();
                    sbQuery.AppendLine("SELECT [PRODUCTID] ");
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
                    sbQuery.AppendLine("      ,[POSTINGTIME] ");
                    sbQuery.AppendLine("      ,[LASTMODIFIER] ");
                    sbQuery.AppendLine("      ,[LASTMODIFIEDTIME] ");
                    sbQuery.AppendLine(" FROM [seowoncarasp].[SEOWON_PRODUCT] ");
                    sbQuery.AppendLine("WHERE [PRODUCTID] = '"+ s_productid + "' ");
                    SqlDataReader reader = ccm.fnQuerySQL(sbQuery.ToString(), "SELECT");


                    while (reader.Read())
                    {
                        lblMANUFACTURER.Text = reader["MANUFACTURER"].ToString();
                        lblNAME.Text = reader["NAME"].ToString();
                        lblPARTNUM.Text = reader["PARTNUM"].ToString();
                        lblPRODUCTID.Text = reader["PRODUCTID"].ToString();
                        lblPRODUCTINFO.Text = reader["PRODUCTINFO"].ToString();
                        lblVIN.Text = reader["VIN"].ToString();
                        lblYEAR.Text = reader["YEAR"].ToString();

                        lblMOREINFO.Text = reader["MOREINFO"].ToString();
                        lblRETURNINFO.Text = reader["RETURNINFO"].ToString();
                        lblSHIPPINGINFO .Text = reader["SHIPPINGINFO"].ToString();
                    }
                    reader.Close();




                    //이미지 넣기
                    //s_productid = "202104062250123";
                    string sPath = Request.Url.ToString();
                    if (sPath.ToUpper().Contains("LOCALHOST"))
                    {
                        sPath = @"D:\work\SeowoncarASP\board\upload";
                    }
                    else
                    {
                        sPath = @"F:\HOME\seowoncarasp\www\board\upload";
                    }
                    string sYear = s_productid.Substring(0, 4);
                    string sMonth = s_productid.Substring(4, 2);
                    string sImageName = s_productid.Substring(6);

                    sPath = sPath + "\\" + sYear + "\\" + sMonth;


                    DirectoryInfo diPathImage = new DirectoryInfo(sPath);
                    string sCondition = string.Format("{0}_*.*", sImageName);
                    FileInfo[] fiImageArray = diPathImage.GetFiles(sCondition, SearchOption.TopDirectoryOnly);


                    StringBuilder sbTagImage = new StringBuilder();
                    int iCount = 0;
                    foreach(FileInfo fi in fiImageArray)
                    {
                        if (iCount == 0) {
                            iCount++;
                            continue; 
                        }

                        sbTagImage.AppendLine(string.Format("<img src = \"board/upload/{0}/{1}/{2}_{3}.jpg\" class=\"img-fluid\" alt=\"\">",sYear,sMonth,sImageName, iCount));
                        iCount++;
                    }
                    imgParent.InnerHtml = sbTagImage.ToString();

                    lblMOREINFO.Text = sbTagImage.ToString() + lblMOREINFO.Text;

                }
                catch
                {
                    //Response.Write( "Excaption-> " + e.Message + " -> " + e.Source + " -> " + e.StackTrace );
                    
                }


                //다른방법으로 섬네일 만들기
                //CommonClassMain ih = new CommonClassMain();
                //ih.GetThumnailImage( "062250123_1.jpg", @"D:\work\SeowoncarASP\board\upload\2021\04");

                


            }
            else
            {

            }
        }
         
    }


}
