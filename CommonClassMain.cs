using System;
using System.Collections.Generic;
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
        public void GetThumnailImage(string filename, string path)
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

        public SqlDataReader fnQuerySQL(string sQuery, string sTypeDML)
        {

            string sPassword = fnAESDecrypt128("jANcacUQjuhFgKKbaNmreyOhQSJPK5khoktXsmwrWKk=", "19851024");


            string connectingString = "server = tcp:sql19-001.cafe24.com,1433; uid = seowoncarasp; pwd = " + sPassword + "; database = seowoncarasp;";
            SqlConnection scon = new SqlConnection(connectingString);
            SqlCommand scom = new SqlCommand();
            scom.Connection = scon;
            scom.CommandText = sQuery;
            scom.CommandTimeout = 8;
            scon.Open();

            
            SqlDataReader reader = scom.ExecuteReader();

            
            return reader;
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



    }
}