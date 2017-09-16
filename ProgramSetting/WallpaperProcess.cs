using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ProgramSetting
{
    public class WallpaperProcess
    {
        private static string dir = AppDomain.CurrentDomain.BaseDirectory;

        /**
         *获取壁纸网络地址 
         */
        public static string getURL()
        {
            string InfoUrl = "http://cn.bing.com/HPImageArchive.aspx?idx=0&n=1";
            string ImageUrl = "0";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(InfoUrl);
                request.Method = "GET"; request.ContentType = "text/html;charset=UTF-8";
                string XmlString;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream myResponseStream = response.GetResponseStream();
                    using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8))
                    {
                        XmlString = myStreamReader.ReadToEnd();
                    }
                }
                // 定义正则表达式用来匹配标签
                Regex regImg = new Regex("<Url>(?<imgUrl>.*?)</Url>", RegexOptions.IgnoreCase);
                // 搜索匹配的字符串
                MatchCollection matches = regImg.Matches(XmlString);
                // 取得匹配项列表
                ImageUrl = "http://www.bing.com" + matches[0].Groups["imgUrl"].Value;

                if (ConfigOperation.getXmlValue(dir.Substring(0, dir.Length - 1), "WallpaperSize") == "0")
                {
                    ImageUrl = ImageUrl.Replace("1366x768", "1920x1080");
                    //label1.Text = ImageUrl;
                }
                else if (ConfigOperation.getXmlValue(dir.Substring(0, dir.Length - 1), "WallpaperSize") == "2")
                {
                    ImageUrl = ImageUrl.Replace("1366x768", "1920x1200");
                    //label1.Text = ImageUrl;
                }
            }
            catch (Exception e)
            {
                return "0";

            }
            return ImageUrl;
        }
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
        int uAction,
        int uParam,
        string lpvParam,
        int fuWinIni
        );
        public static void setWallpaper()
        {
            if (getURL() == "0")
                return;
            //设置墙纸


            string year = DateTime.Now.Year.ToString();
            int m = DateTime.Now.Month;
            int d = DateTime.Now.Day;
            string month = m.ToString();
            string day = d.ToString();
            month = m < 10 ? "0" + m : "" + m;
            day = d < 10 ? "0" + d : "" + d;
            string strSavePath = ConfigOperation.getXmlValue(dir.Substring(0, dir.Length - 1), "ImageSavePath") + "\\bing" + year + month + day + ".jpg";
            if (File.Exists(strSavePath))
            {
                //存在文件
                SystemParametersInfo(20, 1, strSavePath, 1);
            }
            else
            {
                Bitmap bmpWallpaper;
                WebRequest webreq = WebRequest.Create(getURL());
                WebResponse webres = webreq.GetResponse();
                using (Stream stream = webres.GetResponseStream())
                {

                    bmpWallpaper = (Bitmap)Image.FromStream(stream);
                    //stream.Close();
                    if (!Directory.Exists(ConfigOperation.getXmlValue(dir.Substring(0, dir.Length - 1), "ImageSavePath")))
                    {
                        Directory.CreateDirectory(ConfigOperation.getXmlValue(dir.Substring(0, dir.Length - 1), "ImageSavePath"));
                    }
                    bmpWallpaper.Save(strSavePath, ImageFormat.Jpeg); //图片保存路径为相对路径，保存在程序的目录下
                                                                      //Console.WriteLine(ConfigOperation.getXmlValue(path, "ImageSavePath"));
                }

                SystemParametersInfo(20, 1, strSavePath, 1);
            }
        }
    }
}
