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
using System.Xml;

namespace SeowoncarASP.board
{
    public partial class product_list : System.Web.UI.Page
    {

        CommonClassMain CCM = new CommonClassMain();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //if (Session["power"] == null || Int32.Parse(Session["power"].ToString()) < 10)
                //{
                //    Response.Redirect("/");
                //}

                

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


                SqlCommand scCmd2 = new SqlCommand(sbQuery2.ToString());
                SqlDataReader reader2 = CCM.fnQuerySQL(scCmd2, "SELECT");

                XmlDocument xDoc = new XmlDocument();

                // < div class="row" id="divProuduct" runat="server">
                XmlElement xeDivRow = xDoc.CreateElement("div");
                XmlAttribute xaClassRow = xDoc.CreateAttribute("class");
                xaClassRow.Value = "row";
                xeDivRow.Attributes.Append(xaClassRow);
                xDoc.AppendChild(xeDivRow);

                while (reader2.Read())
                {
                    string sMANUFACTURER = reader2["MANUFACTURER"].ToString();
                    string sPRODUCTID = reader2["PRODUCTID"].ToString();
                    string sNAME = reader2["NAME"].ToString();
                    string sYEAR = reader2["YEAR"].ToString();
                    string sPath = CCM.fnUploadPath(Request.Url.ToString());

                    string sImgFullPath = CCM.fnGetImgFullPath(sPath, sPRODUCTID)[0];


                    XmlElement xDivTop = xDoc.CreateElement("div");
                    XmlAttribute xaClassTop = xDoc.CreateAttribute("class");
                    xaClassTop.Value = "col-lg-4 col-md-6 d-flex align-items-stretch";
                    xDivTop.Attributes.Append(xaClassTop);
                    xeDivRow.AppendChild(xDivTop);

                    {
                        XmlElement xeDivMember = xDoc.CreateElement("div");
                        XmlAttribute xaClassMember = xDoc.CreateAttribute("class");
                        xaClassMember.Value = "member";
                        xeDivMember.Attributes.Append(xaClassMember);
                        xDivTop.AppendChild(xeDivMember);
                        {
                            XmlElement xeDivMemberIMG = xDoc.CreateElement("div");
                            XmlAttribute xaClassMemberIMG = xDoc.CreateAttribute("class");
                            xaClassMemberIMG.Value = "member-img";
                            xeDivMemberIMG.Attributes.Append(xaClassMemberIMG);
                            xeDivMember.AppendChild(xeDivMemberIMG);
                            {
                                XmlElement xeIMG = xDoc.CreateElement("img");
                                XmlAttribute xaSRC = xDoc.CreateAttribute("src");
                                xaSRC.Value = sImgFullPath;
                                XmlAttribute xaClass = xDoc.CreateAttribute("class");
                                xaClass.Value = "img-fluid";
                                XmlAttribute xaALT = xDoc.CreateAttribute("alt");
                                xaALT.Value = "";


                                xeIMG.Attributes.Append(xaSRC);
                                xeIMG.Attributes.Append(xaClass);
                                xeIMG.Attributes.Append(xaALT);

                                xeDivMemberIMG.AppendChild(xeIMG);
                            }

                        }

                        {

                            XmlElement xeDivMemberINFO = xDoc.CreateElement("div");
                            XmlAttribute xaClassMemberINFO = xDoc.CreateAttribute("class");
                            xaClassMemberINFO.Value = "member-info";
                            xeDivMemberINFO.Attributes.Append(xaClassMemberINFO);

                            xeDivMember.AppendChild(xeDivMemberINFO);
                            {
                                XmlElement xeH4 = xDoc.CreateElement("h4");
                                xeH4.InnerText = string.Format("{0} - {1}({2})", sMANUFACTURER, sNAME, sYEAR); 

                                XmlElement xeSPAN = xDoc.CreateElement("span");
                                xeSPAN.InnerText = sPRODUCTID;

                                XmlElement xeP = xDoc.CreateElement("p");
                                xeP.InnerXml = "<input onclick=\"fnInsertProductid('"+sPRODUCTID+"')\" class=\"button-list\" id=\"Submit1\" type=\"button\" value=\"수정\" /> " + "<input onclick=\"fnDeleteProductid('" + sPRODUCTID + "')\" class=\"button-list\" id=\"Submit2\" type=\"button\" value=\"삭제\" />";

                                xeDivMemberINFO.AppendChild(xeH4);
                                xeDivMemberINFO.AppendChild(xeSPAN);
                                xeDivMemberINFO.AppendChild(xeP);

                            }

                        }

                    }


                }
                reader2.Close();
                


                    divProuduct.InnerHtml = xDoc.OuterXml;





            }
            else
            {
                //수정, 혹은 삭제

                //수정일 경우
                //
                string sProductid = Request.Form["productid"];
                string sDMLType = Request.Form["dmltype"];

                Session["productid"] = sProductid;

                if (sDMLType.ToUpper().Equals("DELETE"))
                {
                    Response.Redirect("/board/product_delete");
                }
                else if (sDMLType.ToUpper().Equals("UPDATE"))
                {
                    Response.Redirect("/board/product_update");
                }

            }
        }
    }
}