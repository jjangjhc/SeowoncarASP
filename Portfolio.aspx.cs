using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace SeowoncarASP
{
    public partial class Portfolio : Page
    {
        CommonClassMain CCM = new CommonClassMain();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //데이터 베이스 긁어서 카테고리 만들기
                fnGenerateCategory();

            }
            else
            {

            }

        }



        private void fnGenerateCategory()
        {
            



            StringBuilder sbQuery = new StringBuilder();
            sbQuery.AppendLine("SELECT DISTINCT [MANUFACTURER] ");
            sbQuery.AppendLine(" FROM [seowoncarasp].[SEOWON_PRODUCT] ");

            SqlCommand scCmd = new SqlCommand(sbQuery.ToString());
            SqlDataReader reader = CCM.fnQuerySQL(scCmd, "SELECT");


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
            xDoc.LoadXml(divCategory.InnerText);



            foreach (XmlNode xnTopDIV in xDoc.FirstChild.ChildNodes)
            {
                if (xnTopDIV.Attributes["class"].Value.Equals("row"))
                {
                    XmlNode xn = xnTopDIV.FirstChild.FirstChild;
                    xn.RemoveAll();

                    XmlAttribute attUL = xDoc.CreateAttribute("id");
                    attUL.Value = "portfolio-flters";
                    xn.Attributes.Append(attUL);


                    XmlElement xeLI_ALL = xDoc.CreateElement("li");
                    XmlAttribute attLI_ALL = xDoc.CreateAttribute("data-filter");
                    attLI_ALL.Value = "*";
                    XmlAttribute attLI_Class = xDoc.CreateAttribute("class");
                    attLI_Class.Value = "filter-active";

                    xeLI_ALL.Attributes.Append(attLI_ALL);
                    xeLI_ALL.Attributes.Append(attLI_Class);
                    xeLI_ALL.InnerText = "전체";
                    xn.AppendChild(xeLI_ALL);

                    while (reader.Read())
                    {
                        string sMANUFACTURER = reader["MANUFACTURER"].ToString();

                        XmlElement xeLI = xDoc.CreateElement("li");
                        XmlAttribute attLI = xDoc.CreateAttribute("data-filter");
                        attLI.Value = ".filter-" + sMANUFACTURER;
                        xeLI.Attributes.Append(attLI);
                        xeLI.InnerText = sMANUFACTURER;
                        xn.AppendChild(xeLI);
                    }

                    reader.Close();

                }else if (xnTopDIV.Attributes["class"].Value.Equals("row portfolio-container"))
                {
                    XmlNode xn = xnTopDIV;
                    xn.RemoveAll();

                    //class="row portfolio-container" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500"
                    XmlAttribute attClass0 = xDoc.CreateAttribute("class");
                    attClass0.Value = "row portfolio-container";
                    XmlAttribute attdata_aos = xDoc.CreateAttribute("data-aos");
                    attdata_aos.Value = "fade-up";
                    XmlAttribute attdata_aos_easing = xDoc.CreateAttribute("data-aos-easing");
                    attdata_aos_easing.Value = "ease-in-out";
                    XmlAttribute attdata_aos_duration = xDoc.CreateAttribute("data-aos-duration");
                    attdata_aos_duration.Value = "500";

                    xn.Attributes.Append(attClass0);
                    xn.Attributes.Append(attdata_aos);
                    xn.Attributes.Append(attdata_aos_easing);
                    xn.Attributes.Append(attdata_aos_duration);

                    

                    while (reader2.Read())
                    {
                        string sMANUFACTURER = reader2["MANUFACTURER"].ToString();
                        string sPRODUCTID = reader2["PRODUCTID"].ToString();
                        string sNAME = reader2["NAME"].ToString();

                        XmlElement xlDIV = xDoc.CreateElement("div");
                        XmlAttribute attClass = xDoc.CreateAttribute("class");
                        attClass.Value = "col-lg-4 col-md-6 filter-" + sMANUFACTURER;
                        xlDIV.Attributes.Append(attClass);
                        xn.AppendChild(xlDIV);


                        {
                            XmlElement xlDIV2 = xDoc.CreateElement("div");
                            XmlAttribute attClass2 = xDoc.CreateAttribute("class");
                            attClass2.Value = "portfolio-item";
                            xlDIV2.Attributes.Append(attClass2);
                            xlDIV.AppendChild(xlDIV2);

                            {
                                //이미지 넣기
                                //s_productid = "202104062250123";

                                string sPath = CCM.fnUploadPath(Request.Url.ToString());

                                string sImgFullPath = CCM.fnGetImgFullPath(sPath, sPRODUCTID, 0);




                                XmlElement xlimg = xDoc.CreateElement("img");
                                XmlAttribute attsrc = xDoc.CreateAttribute("src");
                                attsrc.Value = sImgFullPath;
                                XmlAttribute attClass4 = xDoc.CreateAttribute("class");
                                attClass4.Value = "img-fluid";
                                XmlAttribute attalt = xDoc.CreateAttribute("alt");
                                attalt.Value = "-";

                                xlimg.Attributes.Append(attsrc);
                                xlimg.Attributes.Append(attClass4);
                                xlimg.Attributes.Append(attalt);
                                xlDIV2.AppendChild(xlimg);

                                XmlElement xlDIV3 = xDoc.CreateElement("div");
                                XmlAttribute attClass6 = xDoc.CreateAttribute("class");
                                attClass6.Value = "portfolio-info";
                                xlDIV3.Attributes.Append(attClass6);
                                xlDIV2.AppendChild(xlDIV3);

                                {
                                    XmlElement xlH3 = xDoc.CreateElement("h3");
                                    xlDIV3.AppendChild(xlH3);

                                    {
                                        XmlElement xlA = xDoc.CreateElement("a");
                                        XmlAttribute attHref = xDoc.CreateAttribute("href");
                                        attHref.Value = sImgFullPath;
                                        XmlAttribute attdata_gall = xDoc.CreateAttribute("data-gall");
                                        attdata_gall.Value = "portfolioGallery";
                                        XmlAttribute attclass7 = xDoc.CreateAttribute("class");
                                        attclass7.Value = "venobox";
                                        XmlAttribute atttitle = xDoc.CreateAttribute("title");
                                        atttitle.Value = sMANUFACTURER;

                                        xlA.Attributes.Append(attHref);
                                        xlA.Attributes.Append(attdata_gall);
                                        xlA.Attributes.Append(attclass7);
                                        xlA.Attributes.Append(atttitle);
                                        xlA.InnerText = sMANUFACTURER + "-" + sNAME;

                                        xlH3.AppendChild(xlA);

                                    }

                                    XmlElement xlDIV4 = xDoc.CreateElement("div");
                                    xlDIV3.AppendChild(xlDIV4);

                                  
                                    {
                                        XmlElement xlA2 = xDoc.CreateElement("a");
                                        XmlAttribute attHref2 = xDoc.CreateAttribute("href");
                                        attHref2.Value = sImgFullPath;
                                        XmlAttribute attdata_gall2 = xDoc.CreateAttribute("data-gall");
                                        attdata_gall2.Value = "portfolioGallery";
                                        XmlAttribute attclass72 = xDoc.CreateAttribute("class");
                                        attclass72.Value = "venobox";
                                        XmlAttribute atttitle2 = xDoc.CreateAttribute("title");
                                        atttitle2.Value = sMANUFACTURER;

                                        xlA2.Attributes.Append(attHref2);
                                        xlA2.Attributes.Append(attdata_gall2);
                                        xlA2.Attributes.Append(attclass72);
                                        xlA2.Attributes.Append(atttitle2);
                                        
                                        xlDIV4.AppendChild(xlA2);

                                        {
                                            XmlElement xlI = xDoc.CreateElement("i");
                                            XmlAttribute attClass8 = xDoc.CreateAttribute("class");
                                            attClass8.Value = "bx bx-plus";
                                            xlI.Attributes.Append(attClass8);
                                            xlI.InnerText = " ";

                                            xlA2.AppendChild(xlI);
                                        }

                                        XmlElement xlA23 = xDoc.CreateElement("a");
                                        XmlAttribute attHref23 = xDoc.CreateAttribute("href");
                                        attHref23.Value = "portfolio-details.aspx?productid=" + sPRODUCTID;
                                        XmlAttribute atttitle23 = xDoc.CreateAttribute("title");
                                        atttitle23.Value = "Portfolio Details";

                                        xlA23.Attributes.Append(attHref23);
                                        xlA23.Attributes.Append(atttitle23);

                                        xlDIV4.AppendChild(xlA23);

                                        {
                                            XmlElement xlI = xDoc.CreateElement("i");
                                            xlI.InnerText = " ";
                                            XmlAttribute attClass8 = xDoc.CreateAttribute("class");
                                            attClass8.Value = "bx bx-link";
                                            xlI.Attributes.Append(attClass8);

                                            xlA23.AppendChild(xlI);
                                        }

                                    }
                                }
                            }
                        }
                        




                    }//while

                    reader2.Close();
                 
                }
            }


            divCategory.InnerHtml = xDoc.OuterXml;



                //                portfolio_flters.InnerText = sbInnerText.ToString();
            

        }

    }

}