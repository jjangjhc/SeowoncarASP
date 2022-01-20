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

                        //이미지 갯수만큼 이미지 만들고 divImages에다가 넣기로 변경

                        divImages.Controls.Clear();
                        List<string> listFullPath = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text);
                        
                        
                        foreach (string s in listFullPath)
                        {
                            int i = listFullPath.IndexOf(s);

                            Panel p = new Panel();
                            p.CssClass = "col-lg-4 col-md-6";

                            Image img = new Image();
                            img.ImageUrl = s;
                            img.ID = "img" + i;
                            img.CssClass = "image-width100";

                            Panel p2 = new Panel();
                            p2.Attributes.Add("style", "height: 30px; background-color: transparent; text-align:left;display:block;");
                            p2.CssClass = "col-md-12";

                            Button btn = new Button();
                            btn.Text = "<<앞으로";
                            btn.Attributes.Add("style", "height: 30px; width:80px;  display: inline-block");
                            btn.OnClientClick = string.Format("fnImageChange('pre',{0});return false;", i);
                            btn.UseSubmitBehavior = false;
                            btn.CssClass = "button-list";

                            Button btn2 = new Button();
                            btn2.Text = "뒤로>>";
                            btn2.UseSubmitBehavior = false;
                            btn2.Attributes.Add("style", "height: 30px; width:80px; display: inline-block");
                            btn2.OnClientClick = string.Format("fnImageChange('next',{0});return false;", i);
                            btn2.CssClass = "button-list";

                            if (listFullPath.IndexOf(s) == 0)
                            {
                                p.Controls.Add(img);
                                
                                divImages.Controls.Add(p);
                            }
                            else
                            {
                                p2.Controls.Add(btn);
                                p2.Controls.Add(btn2);

                                p.Controls.Add(img);
                                p.Controls.Add(p2);

                                divImages.Controls.Add(p);
                            }

                            

                        }

                        /*
                        Image1.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text)[0];
                        Image2.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text)[1];
                        Image3.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text)[2];
                        Image4.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text)[3];
                        Image5.ImageUrl = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text)[4];



                        Image1.CssClass = "image-width100";
                        Image2.CssClass = "image-width100";
                        Image3.CssClass = "image-width100";
                        Image4.CssClass = "image-width100";
                        Image5.CssClass = "image-width100";
                        */
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



                //파일 순서가 바뀌었으면 파일이름 변경

                string sImageChangeName = ImageChange.Value;
                List<string> listChangedName = new List<string>();
                string sPath = CCM.fnUploadPath(Request.Url.ToString());


                if (sImageChangeName.Split(';').Length > 2)
                {

                    foreach (string s in sImageChangeName.Split(';'))
                    {
                        if (s.Length > 0)
                        {
                            //변경이 필요하면 여기서 변경
                            //D:\work\SeowoncarASP\board\upload
                            //https://localhost:44386/board/upload/2021/04/280055593_0.jpg


                            string sPathReplace = s.Substring(s.IndexOf("upload"));
                            sPathReplace = sPathReplace.Replace("/", "\\");
                            sPathReplace = sPathReplace.Replace("upload\\", "");

                            string sPathFile = Path.Combine(sPath, sPathReplace);
                            listChangedName.Add(sPathFile);
                        }
                    }

                    
                    List<string> listFullPath = CCM.fnGetImgFullPath(sPath, txtPRODUCTID.Text);
                    ///board/upload/2021/04/280055593_0.jpg
                    List<string> listRenameFull = new List<string>();
                    
                    foreach (string s in listFullPath)
                    {
                        string sPathReplace = s.Substring(s.IndexOf("upload"));
                        sPathReplace = sPathReplace.Replace("/", "\\");
                        sPathReplace = sPathReplace.Replace("upload\\", "");

                        string sPathFile = Path.Combine(sPath, sPathReplace);

                        FileInfo fi = new FileInfo(sPathFile);
                        fi.CopyTo(fi.FullName + ".old",true);
                        listRenameFull.Add(fi.FullName);
                    }

                    
                    foreach(string s in listChangedName)
                    {
                        int iIndex = listChangedName.IndexOf(s);

                        FileInfo fi = new FileInfo(s + ".old");
                        fi.CopyTo(listRenameFull[iIndex],true);
                    }


                    foreach (string s in listChangedName)
                    {
                     
                        FileInfo fi = new FileInfo(s + ".old");
                        fi.Delete();
                    }


                }






                Session["productid"] = null;

                //입력후 
                Response.Redirect("/board/product_list");


            }



        }
    }
}

