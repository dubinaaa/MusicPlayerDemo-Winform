using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerDemo
{
    public partial class MyCollection : Form
    {
        //存储MyCollection中ListBox中的音乐全路径
        public static Dictionary<string, string> MCFilePathsDictory = new Dictionary<string, string>();
        public static ListBox mcListBox;
        public MyCollection()
        {
            InitializeComponent();
            mcListBox = this.myCollectionListBox;
            
        }
        //listBox的item选中项改变时播放选中歌曲
        private void myCollectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)myCollectionListBox.SelectedItem!=null)
            {
                HomePage.hpListBox.SelectedIndex = -1;
                WindowsMediaPlayer.wmPlayer.URL = MCFilePathsDictory[(string)myCollectionListBox.SelectedItem];
                WindowsMediaPlayer.wmPlayer.Ctlcontrols.play();
                if ((string)MyCollection.mcListBox.SelectedItem!=null)
                {
                    WindowsMediaPlayer.mName.Text = (string)MyCollection.mcListBox.SelectedItem;
                }
                WindowsMediaPlayer.closeWindowMediaPlay();
                Form1.pl.Text = "||";
            }
            
        }
    }
}
