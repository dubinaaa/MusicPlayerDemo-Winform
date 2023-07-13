using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerDemo
{
    public partial class HomePage : Form
    {
        public static ListBox hpListBox;
        //存储HomePage中ListBox中的音乐全路径
        public static Dictionary<string, string> HPFilePathsDictory = new Dictionary<string, string>();
        public HomePage()
        {
            InitializeComponent();
            hpListBox = this.homePageListBox;
        }
        //listBox的item选中项改变时播放选中歌曲
        private void homePageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)hpListBox.SelectedItem!=null)
            {
                MyCollection.mcListBox.SelectedIndex = -1;
                WindowsMediaPlayer.wmPlayer.URL = HPFilePathsDictory[(string)hpListBox.SelectedItem];
                WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                if (Form1.pCenter.Tag == Form1.HomePage)
                    WindowsMediaPlayer.mName.Text = (string)hpListBox.SelectedItem;
            }
            Form1.pl.Text = "||";
        }
    }
}
