using AxWMPLib;
using Ookii.Dialogs.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerDemo
{
    public partial class Form1 : Form
    {
        public static Panel pCenter;
        public static Label pl;
        public static Label lab2;
        
        public Form1()
        {
            InitializeComponent();
            WindowsMediaPlayer.axWindowsMediaPlayer1.uiMode = "none";
            pCenter = this.panelCenter;
            pl = this.play;
            lab2 = this.label2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载窗体时初始化首页
            loadForm(HomePage);
        }
         
        private bool IsDraging = false;
        private int MouseX;
        private int MouseY;
        public static HomePage HomePage = new HomePage();
        public static MyCollection MyCollection = new MyCollection();
        public static WindowsMediaPlayer WindowsMediaPlayer = new WindowsMediaPlayer();
        private string[] FilePaths;//文件全路径
        private string FileName;//文件名
        private string[] LocalMusic;
        private readonly string LocalMusicPath = Application.StartupPath + "/Musics/";

        //缩小
        private void Reduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //关闭
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 拖动面板
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDraging = true;
                MouseX = e.X;
                MouseY = e.Y;
            }
        }
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDraging)
            {
                this.Left += e.X - MouseX;
                this.Top += e.Y - MouseY;
            }
        }
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            IsDraging = false;
        }


        #endregion
        #region 点击加载窗体
        public static void loadForm(object form)
        {
            if (pCenter.Controls.Count > 0)
                pCenter.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pCenter.Controls.Add(f);
            pCenter.Tag = f;
            f.Show();
        }
        //弹出我的收藏并加载音乐
        private void MyCollection_Click(object sender, EventArgs e)
        {
            loadForm(MyCollection);
            LoadlocalMusic();
        }
        //加载我的收藏音乐
        public void LoadlocalMusic()
        {
            LocalMusic = Directory.GetFiles(LocalMusicPath, "*.*").
                Where(file => file.EndsWith(".mp3") || file.EndsWith(".mp4")).ToArray();
            foreach (var filePath in LocalMusic)
            {
                FileName = Path.GetFileNameWithoutExtension(filePath);
                if (!MyCollection.myCollectionListBox.Items.Contains(FileName))
                {
                    MyCollection.myCollectionListBox.Items.Add(FileName);
                }
                if (!MyCollection.MCFilePathsDictory.Keys.Contains(FileName))
                {
                    MyCollection.MCFilePathsDictory.Add(FileName, filePath);
                }
            }
        }
        //弹出首页
        private void homePage_Click(object sender, EventArgs e)
        {
            loadForm(HomePage);
        }
        //弹出视频窗口
        private void phonograph_Click(object sender, EventArgs e)
        {
            if (HomePage.hpListBox.SelectedItem != null)
            {
                if (panelCenter.Tag == HomePage)
                    loadForm(WindowsMediaPlayer);
                else
                    loadForm(HomePage);
            }

            if (MyCollection.mcListBox.SelectedItem != null)
            {
                if (panelCenter.Tag == MyCollection)
                {
                    loadForm(WindowsMediaPlayer);
                }
                else
                    loadForm(MyCollection);
            }
        }
        #endregion
        //文件夹
        private void folder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "选择音乐|*.mp3;*.mp4";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePaths = ofd.FileNames;
                foreach (var filePath in FilePaths)
                {
                    FileName = Path.GetFileNameWithoutExtension(filePath);
                    if (!HomePage.homePageListBox.Items.Contains(FileName))
                    {
                        HomePage.homePageListBox.Items.Add(FileName);

                    }
                    if (!HomePage.HPFilePathsDictory.Keys.Contains(FileName))
                    {
                        HomePage.HPFilePathsDictory.Add(FileName, filePath);
                    }
                }
                loadForm(HomePage);
            }
        }
        //音量
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            WindowsMediaPlayer.axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label4.Text = trackBar1.Value + "%";
        }

        //目录
        private void directory_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog vfbd = new VistaFolderBrowserDialog();
            if (vfbd.ShowDialog() == DialogResult.OK)
            {
                string filePath = vfbd.SelectedPath;
                FilePaths = Directory.GetFiles(filePath);
                foreach (var fp in FilePaths)
                {
                    FileName = Path.GetFileNameWithoutExtension(fp);
                    if (!HomePage.homePageListBox.Items.Contains(FileName))
                    {
                        HomePage.homePageListBox.Items.Add(FileName);
                    }
                    if (!HomePage.HPFilePathsDictory.Keys.Contains(FileName))
                    {
                        HomePage.HPFilePathsDictory.Add(FileName, fp);
                    }
                }
                loadForm(HomePage);
            }

        }
        //播放
        private void play_Click(object sender, EventArgs e)
        {
            if (HomePage.hpListBox.SelectedItem!=null||MyCollection.mcListBox.SelectedItem != null)
            {
                if (play.Text == "||")
                {
                    play.Text = "◀";
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.pause();
                }
                else
                {
                    play.Text = "||";
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "顺序播放")
            {
                label2.Text = "随机播放";
            }
            else if (label2.Text == "随机播放")
            {
                label2.Text = "单曲循环";
            }
            else
            {
                label2.Text = "顺序播放";
            }
        }

        #region 播放模式
        public static void playMode(bool mode)
        {
            string[] valuesArray ;
            Dictionary<string, string> dictionary;
            ListBox listBox;
            if (pCenter.Tag == HomePage)
            {
                listBox = HomePage.hpListBox;
                valuesArray = HomePage.HPFilePathsDictory.Values.ToArray();
                dictionary = HomePage.HPFilePathsDictory;
            }
            else
            {
                listBox = MyCollection.mcListBox;
                valuesArray = MyCollection.MCFilePathsDictory.Values.ToArray();
                dictionary = MyCollection.MCFilePathsDictory;
            }
            if (lab2.Text == "顺序播放")
            {
                if (mode)
                {
                    if (listBox.SelectedIndex < listBox.Items.Count - 1)
                    {
                        listBox.SelectedIndex += 1;
                    }
                    else
                        listBox.SelectedIndex = 0;
                }
                else
                {
                    if (listBox.SelectedIndex >= 0)
                    {
                        if (listBox.SelectedIndex == 0)
                            listBox.SelectedIndex = listBox.Items.Count - 1;
                        else
                            listBox.SelectedIndex -= 1;
                    }
                }

            }
            else if (lab2.Text == "随机播放")
            {
               int r = new Random().Next(0, listBox.Items.Count);
                if (r == listBox.SelectedIndex)
                {
                    if ((r + 1) == listBox.Items.Count)
                        r--;
                    else
                        r++;
                }
                if (dictionary.Count > 0)
                {
                    WindowsMediaPlayer.wmPlayer.URL = valuesArray[listBox.SelectedIndex = r];
                    listBox.SelectedItem = Path.GetFileNameWithoutExtension(valuesArray[listBox.SelectedIndex = r]);
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                }
                else
                {
                    WindowsMediaPlayer.wmPlayer.URL = valuesArray[listBox.SelectedIndex = r];
                    listBox.SelectedItem = Path.GetFileNameWithoutExtension(valuesArray[listBox.SelectedIndex = r]);
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                }
            }
            else if (lab2.Text == "单曲循环")
            {
                if (dictionary.Count > 0)
                {
                    WindowsMediaPlayer.wmPlayer.URL = valuesArray[listBox.SelectedIndex];
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                }
                else
                {
                    WindowsMediaPlayer.wmPlayer.URL = valuesArray[listBox.SelectedIndex];
                    WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                }
            }
            
        }
        #endregion
        //上一曲
        private void button7_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.closeWindowMediaPlay();
            playMode(false);
        }
        //下一曲
        private void button9_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.closeWindowMediaPlay();
            playMode(true);
        }
        
        //添加到我的收藏
        private void like_Click(object sender, EventArgs e)
        {
            string likeMusicPath = Application.StartupPath + "/Musics";
            if (HomePage.hpListBox.SelectedItem != null)
            {
                string filePath = HomePage.HPFilePathsDictory[(string)HomePage.hpListBox.SelectedItem];
                FileName = Path.GetFileName(filePath);
                string destinationFilePath = Path.Combine(LocalMusicPath, FileName);
                try
                {
                    if (filePath != null)
                    {
                        File.Copy(filePath, destinationFilePath);
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("文件不存在");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(FileName + "已添加到我的收藏");
                }
            }
        }


    }
}
