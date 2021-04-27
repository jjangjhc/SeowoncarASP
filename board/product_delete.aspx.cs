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
    public partial class product_delete : System.Web.UI.Page
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
                    //delete
                    StringBuilder sbQuery = new StringBuilder();
                    sbQuery.AppendLine("DELETE FROM [seowoncarasp].[SEOWON_PRODUCT]  ");
                    sbQuery.AppendLine(" WHERE [PRODUCTID] = @PRODUCTID    ");

                    SqlCommand cmd = new SqlCommand(sbQuery.ToString());
                    cmd.Parameters.AddWithValue("@PRODUCTID", Session["productid"].ToString());

                    



                    //이미지 파일 삭제
                    string sProductID = Session["productid"].ToString();
                    string sUploadPath = CCM.fnUploadPath(Request.Url.ToString());
                    sUploadPath = Path.Combine(sUploadPath, sProductID.Substring(0, 4), sProductID.Substring(4, 2));

                    DirectoryInfo diPathImage = new DirectoryInfo(sUploadPath);
                    FileInfo[] fiArray = diPathImage.GetFiles(sProductID.Substring(6, 9) + "_*.*", SearchOption.TopDirectoryOnly);

                    foreach (FileInfo fi in fiArray)
                    {
                        fi.Delete();
                    }

                    CCM.fnQuerySQL(cmd, "DELETE");


                    //db에 존재하지 않는 파일 삭제
                    //생성 잘 되고 삭제 잘 되면 문제없음
                    fnDeleteServerFiles();


                    Session["productid"] = null;
                    //삭제 후
                    Response.AppendHeader("REFRESH", "3;URL=/board/product_list");
                    //Response.Redirect("/board/product_list");
                }

            }
            else
            {



            }



        }

        private void fnDeleteServerFiles()
        {
            //sUploadPath = @"D:\work\SeowoncarASP\board\upload";
            //sUploadPath = @"F:\HOME\seowoncarasp\www\board\upload";
            //string sUploadPath = CCM.fnUploadPath(Request.Url.ToString());

            //DirectoryInfo di = new DirectoryInfo(sUploadPath);
            //FileInfo[] fiArray = di.GetFiles("*.*", SearchOption.AllDirectories);
            
        }
    }
}
