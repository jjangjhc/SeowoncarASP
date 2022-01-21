using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
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
            chkImport.InputAttributes.Add("class", "input--style-6");


            if (!IsPostBack)
            {
                //처음 화면이 그냥 보여질 경우


                if (Session["power"] == null || Int32.Parse(Session["power"].ToString()) < 10)
                {
                    Response.Redirect("/default");
                }


                //남은용량 체크
                DriveInfo[] drives = DriveInfo.GetDrives();
                StringBuilder sbText = new StringBuilder();
                sbText.AppendLine("남은 사용량 <br />");
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        if (drive.DriveType == DriveType.Fixed)
                        {
                            if (drive.Name.ToString().Contains("F"))
                            {
                                sbText.AppendLine(drive.Name);
                                sbText.AppendLine(drive.AvailableFreeSpace.ToString("#,##0,,MB"));
                                sbText.AppendLine("(전체 용량 : ");
                                sbText.AppendLine(drive.TotalSize.ToString("#,##0,,MB"));
                                sbText.AppendLine(")");
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                    }
            }

                Label1.Text = sbText.ToString();
            }
            else
            {
                //입력값을 입력하자 postback!!
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
                sbQuery.AppendLine("      ,[CATEGORY] ");
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
                sbQuery.AppendLine("      ,@CATEGORY");
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
                cmd.Parameters.AddWithValue("@CATEGORY", chkImport.Checked ? "수입차" : "국산차") ;
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




                CCM.fnQuerySQL(cmd, "INSERT");

                //파일업로드 변경
                int i = 0;

                List<string> listAllowedExtensions = new List<string>();
                listAllowedExtensions.Add(".gif");
                listAllowedExtensions.Add(".png");
                listAllowedExtensions.Add(".jpeg");
                listAllowedExtensions.Add(".jpg");
                listAllowedExtensions.Add(".bmp");


                foreach (HttpPostedFile fu in FileUpload6.PostedFiles)
                {

                    string sFileExtension = System.IO.Path.GetExtension(fu.FileName).ToLower();
                    if (!listAllowedExtensions.Contains(sFileExtension))
                    {
                        continue;
                    }

                    
                    i++;
                    
                    //240952069_4.jpg 이런 형태가 됨
                    string sSavePAth = Path.Combine(sUploadPath, sProductID.Substring(6, 9) + "_" + (i) + sFileExtension);

                    DirectoryInfo diUploadPath = new DirectoryInfo(sUploadPath);
                    if (!diUploadPath.Exists)
                    {
                        diUploadPath.Create();
                    }

                    fu.SaveAs(sSavePAth);


                    //이미지의 가로크기가 1100px이 넘으면 자동 리사이즈
                    Bitmap bmpSource = new Bitmap(sSavePAth);
                    PropertyItem[] propItems = bmpSource.PropertyItems;

                    if (bmpSource.Width > 1000)
                    {
                        int iWidth = 1100;
                        double dRatio = (bmpSource.Height * 1100) / bmpSource.Width;
                        int iHeight = (int)dRatio;

                        Size resize = new Size(iWidth, iHeight);
                        Bitmap resizeImage = new Bitmap(bmpSource, resize);


                        //이미지파일의 메타정보 복사
                        foreach (PropertyItem pi in propItems)
                        {
                            resizeImage.SetPropertyItem(pi);
                        }

                        //기존 파일 연결 끊기
                        bmpSource.Dispose();


                        ImageCodecInfo myImageCodecInfo = null;
                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameter myEncoderParameter;
                        EncoderParameters myEncoderParameters = new EncoderParameters(1);
                        int j;
                        ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
                        for (j = 0; j < encoders.Length; ++j)
                        {
                            if (encoders[j].MimeType == "image/jpeg")
                            {
                                myImageCodecInfo = encoders[j];
                            }
                        }

                        //95레벨로 jpg저장
                        myEncoderParameter = new EncoderParameter(myEncoder, 95L);
                        myEncoderParameters.Param[0] = myEncoderParameter;
                        resizeImage.Save(sSavePAth, myImageCodecInfo, myEncoderParameters);



                    }
                    else
                    {
                        bmpSource.Dispose();
                        continue;
                    }

                }



                Session["productid"] = null;
                //입력후 
                Response.Redirect("/board/product_list");
            }
        }
    }
}
