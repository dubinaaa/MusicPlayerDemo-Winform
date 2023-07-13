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
    public partial class WindowsMediaPlayer : Form
    {
        public static AxWindowsMediaPlayer wmPlayer;
        public static Label mName;

        public WindowsMediaPlayer()
        {
            InitializeComponent();
            wmPlayer = this.axWindowsMediaPlayer1;
            mName = this.musicName;
        }
        //timer动态更新进度条
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)wmPlayer.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)wmPlayer.Ctlcontrols.currentPosition;
                label2.Text = wmPlayer.Ctlcontrols.currentPositionString;
                label3.Text = wmPlayer.Ctlcontrols.currentItem.durationString;
                if (progressBar1.Maximum == progressBar1.Value)
                {
                    wmPlayer.Ctlcontrols.stop();
                    closeWindowMediaPlay();
                }
            }
            else if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                closeWindowMediaPlay();
                Form1.playMode(true);
            }
        }
        //关闭WindowMediaPlayer视频窗口
        public static void closeWindowMediaPlay()
        {
            if (Form1.pCenter.Tag == Form1.WindowsMediaPlayer)
            {
                if (HomePage.hpListBox.SelectedItem!=null)
                {
                    Form1.loadForm(Form1.HomePage);
                }
                else
                    Form1.loadForm(Form1.MyCollection);

            }
        }

        //拉进度条
        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            wmPlayer.Ctlcontrols.currentPosition =
                wmPlayer.currentMedia.duration * e.X / progressBar1.Width;
        }
    }
}
