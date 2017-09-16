using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProgramSetting
{
    public class ConfigOperation
    {
        /// <summary>  
        /// 返回XMl文件指定元素的指定属性值  
        /// </summary>  
        /// <param name="xmlElement">指定元素</param>  
        /// <param name="xmlAttribute">指定属性</param>  
        /// <returns></returns>  
        public static string getXmlValue(string path ,string xmlElement)
        {
            if (!File.Exists(path + @"\Config.xml"))
            {
                //Directory.CreateDirectory(path );
                createConfigXml(path );
            }
           
            string s = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path + @"\Config.xml");
            
            XmlNode memberlist = xmlDoc.SelectSingleNode("Soft/BingWallPaper.Settings");
            XmlNodeList nodelist = memberlist.ChildNodes;
            // XmlNodeList nodelist=xmlDoc.GetElementsByTagName("MEMBER");
            foreach (XmlNode node in nodelist)
            {
                if (node.Attributes["name"].InnerText.ToString().Equals(xmlElement))
                {
                    s = node.ChildNodes[0].InnerText; 
                    break;
                }
            }

            return s;
        }


        /// <summary>  
        /// 设置XMl文件指定元素的指定属性的值  
        /// </summary>  
        /// <param name="xmlElement">指定元素</param>  
        /// <param name="xmlAttribute">指定属性</param>  
        /// <param name="xmlValue">指定值</param>  
        public static void setXmlValue(string path,string xmlElement, string xmlValue)
        {
            if (!File.Exists(path + @"\Config.xml"))
            {
                createConfigXml(path);
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path + @"\Config.xml");
            XmlNode memberlist = xmlDoc.SelectSingleNode("Soft/BingWallPaper.Settings");
            XmlNodeList nodelist = memberlist.ChildNodes;
            // XmlNodeList nodelist=xmlDoc.GetElementsByTagName("MEMBER");
            foreach (XmlNode node in nodelist)
            {
                if (node.Attributes["name"].InnerText.ToString().Equals(xmlElement))
                {
                    node.ChildNodes[0].InnerText = xmlValue;
                    break;
                }
            }
            xmlDoc.Save(path + @"\Config.xml");
        }

        public static void createConfigXml(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //加入XML的声明段落，Save方法不再xml上写出独立属性
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            //加入根元素

            XmlElement root = xmlDoc.CreateElement("Soft");
            xmlDoc.AppendChild(root);
            XmlElement memberlist = xmlDoc.CreateElement("BingWallPaper.Settings");

            XmlElement memberA = xmlDoc.CreateElement("setting");
            memberA.SetAttribute("name", "WallpaperSize");
            XmlElement zs = xmlDoc.CreateElement("value");
            zs.InnerText = "0";
            memberA.AppendChild(zs);

            XmlElement memberB = xmlDoc.CreateElement("setting");
            memberB.SetAttribute("name", "WallpaperStyle");
            XmlElement ww = xmlDoc.CreateElement("value");
            ww.InnerText = "0";
            memberB.AppendChild(ww);

            XmlElement memberC = xmlDoc.CreateElement("setting");
            memberC.SetAttribute("name", "ImageSavePath");
            XmlElement sc = xmlDoc.CreateElement("value");
            sc.InnerText = @"C:\Program Files\BingWallpaper";
            memberC.AppendChild(sc);

            memberlist.AppendChild(memberA);
            memberlist.AppendChild(memberB);
            memberlist.AppendChild(memberC);
            root.AppendChild(memberlist);
            xmlDoc.Save(path+ @"\Config.xml");
        }
    }
}

