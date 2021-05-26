using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SeowoncarASP
{
    public class CommonClassMain
    {
        public void fnGetThumnailImage(string filename, string path)
        {
            byte[] b = null;
            using (FileStream fs = File.OpenRead(path + "\\" + filename))
            {
                //  case Image.FromFile 이용
                //  Image org = Image.FromFile(path + "\\" + filename);
                //  case Image.FromStream 이용 = fileStream 속도 .. 향상
                Image org = Image.FromStream(fs, false, false);
                int oWidth = org.Width;          //  가로
                int oHeight = org.Height;        //  세로
                double sngRatio = 1;                   //  가로 대 세로 비율

                if (oWidth < oHeight)               //  세로가 더큰경우
                {
                    sngRatio = oHeight / oWidth;    //  세로 / 가로  
                }
                else //  가로보다 세로가 더클시
                {
                    sngRatio = (double)oWidth / (double)oHeight;    // 가로 / 세로 
                }

                int nWidth = 350;                    // Thumnail 이미지 40으로세팅
                double nHeight = nWidth / sngRatio;    // 가로 / 비율

                Image tn = org.GetThumbnailImage(nWidth, (int)nHeight, delegate { return false; }, IntPtr.Zero);

                string sRename = filename;
                sRename = sRename.Replace("_1", "_0");
                tn.Save(path + "\\" + sRename);

                tn.Dispose();
                org.Dispose();

                

            }
            //return b;
        }

        internal string fnNewProuductID()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssf");
        }

        internal string fnUploadPath(string sRequestUrl)
        {

            string sUploadPath = sRequestUrl;



            if (sUploadPath.ToUpper().Contains("LOCALHOST"))
            {
                sUploadPath = @"D:\work\SeowoncarASP\board\upload";
            }
            else
            {
                sUploadPath = @"F:\HOME\seowoncarasp\www\board\upload";
            }

            return sUploadPath;
        }

        // IMG to byte[]
        public byte[] ImageToByteArray(Image img)
        {
            ImageConverter cvt = new ImageConverter();
            byte[] b = (byte[])cvt.ConvertTo(img, typeof(byte[]));
            return b;
        }




        //AES_128 암호화
        public String fnAESEncrypt128(String Input, String key)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(Input);
            byte[] Salt = Encoding.ASCII.GetBytes(key.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();

            byte[] CipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);

            return EncryptedData;
        }

        public SqlDataReader fnQuerySQL(SqlCommand scCommand, string sTypeDML)
        {

            string sPassword = fnAESDecrypt128("jANcacUQjuhFgKKbaNmreyOhQSJPK5khoktXsmwrWKk=", "19851024");


            string connectingString = "server = tcp:sql19-001.cafe24.com,1433; uid = seowoncarasp; pwd = " + sPassword + "; database = seowoncarasp;";
            SqlConnection scConn = new SqlConnection(connectingString);
            SqlCommand scCmd = scCommand;
            scCmd.Connection = scConn;

            if (sTypeDML.ToString().Equals("SELECT"))
            {
                scConn.Open();
                SqlDataReader reader = scCmd.ExecuteReader();
                return reader;
            }
            else
            {
                scConn.Open();
                scCmd.ExecuteNonQuery();
                scConn.Close();
                return null;
            }


            


        }

        public DataSet fnQuerySQL_DataSet(SqlCommand scCommand, string sTypeDML)
        {

            string sPassword = fnAESDecrypt128("jANcacUQjuhFgKKbaNmreyOhQSJPK5khoktXsmwrWKk=", "19851024");


            string connectingString = "server = tcp:sql19-001.cafe24.com,1433; uid = seowoncarasp; pwd = " + sPassword + "; database = seowoncarasp;";
            SqlConnection scConn = new SqlConnection(connectingString);
            SqlCommand scCmd = scCommand;
            scCmd.Connection = scConn;

            if (sTypeDML.ToUpper().ToString().Equals("SELECT"))
            {
                DataSet ds = new DataSet();
                // SqlDataAdapter 초기화
                SqlDataAdapter sda = new SqlDataAdapter(scCmd);

                // Fill 메서드 실행하여 결과 DataSet을 리턴받음
                sda.Fill(ds);

                scConn.Close();

                return ds;
            }
            else
            {
                scConn.Open();
                scCmd.ExecuteNonQuery();
                scConn.Close();
                return null;
            }



        }


        //AE_S128 복호화
        public String fnAESDecrypt128(String Input, String key)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(Input);
            byte[] Salt = Encoding.ASCII.GetBytes(key.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream(EncryptedData);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            byte[] PlainText = new byte[EncryptedData.Length];

            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;
        }

        internal string fnGetImgFullPath(string sPath, string sPRODUCTID, int iReturnImg)
        {

            string sYear = sPRODUCTID.Substring(0, 4);
            string sMonth = sPRODUCTID.Substring(4, 2);
            string sImageName = sPRODUCTID.Substring(6);

            sPath = Path.Combine(sPath, sYear, sMonth);


            DirectoryInfo diPathImage = new DirectoryInfo(sPath);
            string sCondition = string.Format("{0}_*.*", sImageName);
            FileInfo[] fiImageArray = diPathImage.GetFiles(sCondition, SearchOption.TopDirectoryOnly);

            try
            {
                //썸네일이 없을경우 생성
                if (!fiImageArray[0].Name.Substring(fiImageArray[0].Name.LastIndexOf("_") + 1, 1).Equals("0"))
                {
                    fnGetThumnailImage(fiImageArray[0].Name, sPath);
                    fiImageArray = diPathImage.GetFiles(sCondition, SearchOption.TopDirectoryOnly);
                }
            }
            catch
            {

            }

            string sImgFullPath = string.Empty;
            if (fiImageArray.Length < 1)
            {
                //이미지 기본값 출력
                //sImgFullPath = "/board/upload/" + sYear + "/" + sMonth + "/062250123_0.jpg";
                sImgFullPath = "/images/no_img.png";
            }
            else
            {
                //원하는 값 출력
                try
                {
                    sImgFullPath = "/board/upload/" + sYear + "/" + sMonth + "/" + fiImageArray[iReturnImg].Name;
                }
                catch
                {
                    //해당 위치에 값이 없어도 이미지 기본값 출력
                    //sImgFullPath = "/board/upload/" + sYear + "/" + sMonth + "/062250123_0.jpg";
                    sImgFullPath = "/images/no_img.png";
                }
            }
            return sImgFullPath;
        }
    }
}