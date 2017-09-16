using Microsoft.Win32;
using ProgramSetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingWallPaper
{
    public partial class mainForm : Form
    {
        public const int WALLPAPER_STYLE_FULL = 1;
        public const int WALLPAPER_STYLE_ADAPT = 2;
        public const int WALLPAPER_STYLE_STRETCH = 3;
        public const int WALLPAPER_STYLE_TILING = 4;
        public const int WALLPAPER_STYLE_CENTER = 5;
        public const int WALLPAPER_STYLE_SPAN = 6;

        public int mTileWallpaper = 0;
        public int mWallpaperStyle = 0;

        private static string dir = AppDomain.CurrentDomain.BaseDirectory;

        public mainForm()
        {

            InitializeComponent();
            checkIsAutoRun();
            setStatusLabel.Text = "正在获取图片";
            setStatusLabel.ForeColor = Color.Blue;
            statusProgressBar.Value += 10;
            Thread th = new Thread(init);
            th.Start();
        }
        public void init()
        {

            string url = "";
            if ((url = WallpaperProcess.getURL()) != "0")
            {
                setStatusLabel.Text = "正在设置壁纸";
                setStatusLabel.ForeColor = Color.Green;
                statusProgressBar.Value += 30;
                setProgramImage(url);//设置背景图片
            }
            else
            {
                statusProgressBar.Value = 0;
                setStatusLabel.Text = "获取失败";
                setStatusLabel.ForeColor = Color.Red;
                return;
            }
            initBackground();
            statusProgressBar.Value += 30;
            WallpaperProcess.setWallpaper();//设置墙纸
            setStatusLabel.Text = "设置成功";
            statusProgressBar.Value = 100;
            setStatusLabel.ForeColor = Color.Blue;
            changeDefaultSetting(int.Parse(ConfigOperation.getXmlValue(Application.StartupPath, "WallpaperSize")),
               int.Parse(ConfigOperation.getXmlValue(Application.StartupPath, "WallpaperStyle")));
        }
        private void initBackground()
        {
            this.pictureBox1.SendToBack();//将背景图片放到最下面
            this.panel1.BackColor = Color.FromArgb(150, 255, 255, 255);//将Panel设为透明
            this.chooseSavePath.BackColor = Color.FromArgb(150, 255, 255, 255);
            this.panel1.Parent = this.pictureBox1;//将panel父控件设为背景图片控件
            this.panel1.BringToFront();//将panel放在前面
        }

        /**
*获取设置 
*/
        public void changeDefaultSetting(int size, int style)
        {
            switch (style)
            {
                case WALLPAPER_STYLE_FULL:   //填充
                    wStyleFull.Checked = true; break;
                case WALLPAPER_STYLE_ADAPT:  //适应
                    wStyleAdapt.Checked = true; break;
                case WALLPAPER_STYLE_STRETCH://拉伸
                    wStyleStretch.Checked = true; break;
                case WALLPAPER_STYLE_TILING: //平铺
                    wStyleTiling.Checked = true; break;
                case WALLPAPER_STYLE_CENTER: //居中
                    wStyleCenter.Checked = true; break;
                case WALLPAPER_STYLE_SPAN:   //跨区
                    wStyleSpan.Checked = true; break;
            }
            switch (size)
            {
                case 0: imageSize1080.Checked = true; break;
                case 1: imageSize720.Checked = true; break;
                case 2: imageSize1080full.Checked = true; break;
            }
            savePath.Text = ConfigOperation.getXmlValue(Application.StartupPath, "ImageSavePath");
        }/**
         *改变样式RadioButton 
         */
        public void changeWallpaperStyle(int style)
        {
            switch (style)
            {
                case WALLPAPER_STYLE_FULL:   //填充
                    mTileWallpaper = 0;
                    mWallpaperStyle = 10; break;
                case WALLPAPER_STYLE_ADAPT:  //适应
                    mTileWallpaper = 0;
                    mWallpaperStyle = 6; break;
                case WALLPAPER_STYLE_STRETCH://拉伸
                    mTileWallpaper = 0;
                    mWallpaperStyle = 2; break;
                case WALLPAPER_STYLE_TILING: //平铺
                    mTileWallpaper = 1;
                    mWallpaperStyle = 0; break;
                case WALLPAPER_STYLE_CENTER: //居中
                    mTileWallpaper = 0;
                    mWallpaperStyle = 0; break;
                case WALLPAPER_STYLE_SPAN:   //跨区
                    mTileWallpaper = 0;
                    mWallpaperStyle = 22; break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string url = WallpaperProcess.getURL();
                string filepath = 111ImageSavePath+"\\pic.bmp";
                WebClient mywebclient = new WebClient();
                mywebclient.DownloadFile(url, filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //label1.Text = ex.Message;
            }*/
            //111ImageSavePath = @"D:\Program Files\BingWallpaper\Image";
            //MessageBox.Show(111ImageSavePath);
            //ProgramSetting.ConfigOperation.createConfigXml(Application.StartupPath);
            //ProgramSetting.ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperSize", "3");
            //MessageBox.Show(ProgramSetting.ConfigOperation.getXmlValue(Application.StartupPath, "WallpaperSize"));

        }

        /**
         *设置程序背景
         */

        public void setProgramImage(string url)
        {
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
                pictureBox1.Image = Image.FromFile(strSavePath);
                pictureBox2.Image = pictureBox1.Image;

            }
            else
            {
                //label1.Text = url;
                WebRequest webreq = WebRequest.Create(url);
                WebResponse webres = webreq.GetResponse();
                using (Stream stream = webres.GetResponseStream())
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    pictureBox2.Image = pictureBox1.Image;
                }
            }
        }

        /**
         * 设置注册表壁纸样式
         */
        private void setRegistryStyle()
        {
            RegistryKey myRegKey = null;
            try
            {
                //设置墙纸显示方式
                myRegKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                //赋值
                //注意：在把数值型的数据赋到注册表里面的时候，
                //如果不加引号，则该键值会成为“REG_DWORD”型；
                //如果加上引号，则该键值会成为“REG_SZ”型。
                myRegKey.SetValue("TileWallpaper", mTileWallpaper.ToString());
                myRegKey.SetValue("WallpaperStyle", mWallpaperStyle.ToString());

                //关闭该项,并将改动保存到磁盘
                myRegKey.Close();
                Thread t = new Thread(WallpaperProcess.setWallpaper);
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册表访问错误:" + ex.Message);
            }
            finally
            {
                if (myRegKey != null)
                {
                    myRegKey.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(WallpaperProcess.setWallpaper);
            t.Start();
            //setWallpaper();
            //savePath.Text = 111ImageSavePath + "\\bing" + DateTime.Now.Year.ToString()+ DateTime.Now.Month.ToString()+ DateTime.Now.Day.ToString() + ".Jpg";
        }

        private void wStyleFull_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleFull.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_FULL);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_FULL.ToString());
                setRegistryStyle();
            }
        }

        private void wStyleAdapt_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleAdapt.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_ADAPT);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_ADAPT.ToString());

                setRegistryStyle();
            }
        }

        private void wStyleStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleStretch.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_STRETCH);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_STRETCH.ToString());
                setRegistryStyle();
            }
        }

        private void wStyleTiling_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleTiling.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_TILING);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_TILING.ToString());
                setRegistryStyle();
            }
        }

        private void wStyleCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleCenter.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_CENTER);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_CENTER.ToString());
                setRegistryStyle();
            }
        }

        private void wStyleSpan_CheckedChanged(object sender, EventArgs e)
        {
            if (wStyleSpan.Checked)
            {
                changeWallpaperStyle(WALLPAPER_STYLE_SPAN);
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperStyle", WALLPAPER_STYLE_SPAN.ToString());
                setRegistryStyle();
            }
        }

        private void imageSize1080_CheckedChanged(object sender, EventArgs e)
        {
            if (imageSize1080.Checked)
            {
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperSize", "0");
                Thread t = new Thread(WallpaperProcess.setWallpaper);
                t.Start();
            }
        }
        private void imageSize1080full_CheckedChanged(object sender, EventArgs e)
        {
            if (imageSize1080full.Checked)
            {
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperSize", "2");
                Thread t = new Thread(WallpaperProcess.setWallpaper);
                t.Start();
            }
        }
        private void imageSize720_CheckedChanged(object sender, EventArgs e)
        {
            if (imageSize720.Checked)
            {
                ConfigOperation.setXmlValue(Application.StartupPath, "WallpaperSize", "1");
                Thread t = new Thread(WallpaperProcess.setWallpaper);
                t.Start();
            }
        }

        private void chooseSavePath_Click(object sender, EventArgs e)
        {
            chooseFolderDialog.RootFolder = System.Environment.SpecialFolder.Desktop;
            chooseFolderDialog.ShowNewFolderButton = true;
            chooseFolderDialog.Description = "请选择目录";
            if (chooseFolderDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigOperation.setXmlValue(Application.StartupPath, "ImageSavePath", chooseFolderDialog.SelectedPath.ToString());
                savePath.Text = chooseFolderDialog.SelectedPath.ToString();
            }
        }


        private void savePath_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(savePath.Text))
                    Directory.CreateDirectory(savePath.Text);
                ConfigOperation.setXmlValue(Application.StartupPath, "ImageSavePath", savePath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("路径非法:" + ex.Message);
            }
        }
        public void SetAutoRun(string fileName, bool isAutoRun)
        {
            //string reSet = string.Empty;
            RegistryKey reg = null;
            try
            {
                fileName = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1) + "AutoSetWallpaper.exe";
                if (!File.Exists(fileName))
                {
                    //reSet = "该文件不存在!";
                    autoRunCheck.Checked = false;
                    MessageBox.Show("文件缺失，请重新下载");
                    return;
                }

                //MessageBox.Show(fileName);
                //return "d";
                string name = "AutoSetWallpaper";
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                {
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                }
                if (isAutoRun)
                {
                    reg.SetValue(name, fileName);
                    //reg.DeleteValue("BingWallPaper");
                    //reSet = "1";
                }
                else
                {
                    //reg.SetValue(name, false);
                    if (reg.GetValue(name) != null)
                        reg.DeleteValue(name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("记录开机自运行错误:" + ex.Message);
            }
            finally
            {
                if (reg != null)
                {
                    reg.Close();
                }
            }
            // return reSet;
        }
        public void checkIsAutoRun()
        {
            RegistryKey reg = null;
            string name = "AutoSetWallpaper";
            reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (reg == null || reg.GetValue(name) == null)
            {
                autoRunCheck.Checked = false;
                //MessageBox.Show("不存在");
            }
            else
            {
                autoRunCheck.Checked = true;
                //MessageBox.Show("存在");
                //SetAutoRun(Application.ExecutablePath, true);//设置自动运行
            }
            if (reg != null)
            {
                reg.Close();
            }
        }

        private void autoRunCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRunCheck.Checked)
            {
                SetAutoRun(Application.ExecutablePath, true);//设置自动运行
            }
            else
            {
                SetAutoRun(Application.ExecutablePath, false);//设置不自动运行
            }
        }
    }
}
