namespace MusicPlayerDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.myCollection = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.Reduce = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.phonograph = new System.Windows.Forms.PictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.like = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonograph)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.myCollection);
            this.panelLeft.Controls.Add(this.homePage);
            this.panelLeft.Controls.Add(this.directory);
            this.panelLeft.Controls.Add(this.folder);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 37);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(185, 608);
            this.panelLeft.TabIndex = 0;
            // 
            // myCollection
            // 
            this.myCollection.BackColor = System.Drawing.Color.White;
            this.myCollection.FlatAppearance.BorderSize = 0;
            this.myCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.myCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCollection.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCollection.ForeColor = System.Drawing.Color.Gray;
            this.myCollection.Image = global::MusicPlayerDemo.Properties.Resources._9004759_star_favorite_award_like_icon;
            this.myCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myCollection.Location = new System.Drawing.Point(12, 268);
            this.myCollection.Name = "myCollection";
            this.myCollection.Size = new System.Drawing.Size(160, 41);
            this.myCollection.TabIndex = 14;
            this.myCollection.Text = "我的收藏";
            this.myCollection.UseVisualStyleBackColor = false;
            this.myCollection.Click += new System.EventHandler(this.MyCollection_Click);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.White;
            this.homePage.FlatAppearance.BorderSize = 0;
            this.homePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.homePage.ForeColor = System.Drawing.Color.Gray;
            this.homePage.Image = global::MusicPlayerDemo.Properties.Resources._1904661_building_dashboard_default_home_house_icon;
            this.homePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homePage.Location = new System.Drawing.Point(12, 221);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(160, 41);
            this.homePage.TabIndex = 2;
            this.homePage.Text = "首页";
            this.homePage.UseVisualStyleBackColor = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // directory
            // 
            this.directory.BackColor = System.Drawing.Color.White;
            this.directory.FlatAppearance.BorderSize = 0;
            this.directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directory.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.directory.ForeColor = System.Drawing.Color.Gray;
            this.directory.Image = global::MusicPlayerDemo.Properties.Resources._8956801_address_book_contact_communication_contacts_icon__1_;
            this.directory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directory.Location = new System.Drawing.Point(12, 403);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(160, 41);
            this.directory.TabIndex = 1;
            this.directory.Text = "目录";
            this.directory.UseVisualStyleBackColor = false;
            this.directory.Click += new System.EventHandler(this.directory_Click);
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.Color.White;
            this.folder.FlatAppearance.BorderSize = 0;
            this.folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folder.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folder.ForeColor = System.Drawing.Color.Gray;
            this.folder.Image = global::MusicPlayerDemo.Properties.Resources._299034_folder_music_icon;
            this.folder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folder.Location = new System.Drawing.Point(12, 461);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(160, 41);
            this.folder.TabIndex = 0;
            this.folder.Text = "文件夹";
            this.folder.UseVisualStyleBackColor = false;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "center";
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTop.Controls.Add(this.Reduce);
            this.panelTop.Controls.Add(this.Close);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(868, 37);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // Reduce
            // 
            this.Reduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reduce.FlatAppearance.BorderSize = 0;
            this.Reduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Reduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reduce.Image = global::MusicPlayerDemo.Properties.Resources._9042840_reduce_icon;
            this.Reduce.Location = new System.Drawing.Point(764, 4);
            this.Reduce.Name = "Reduce";
            this.Reduce.Size = new System.Drawing.Size(30, 30);
            this.Reduce.TabIndex = 1;
            this.Reduce.UseVisualStyleBackColor = true;
            this.Reduce.Click += new System.EventHandler(this.Reduce_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::MusicPlayerDemo.Properties.Resources._9104213_close_cross_remove_delete_icon;
            this.Close.Location = new System.Drawing.Point(823, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelBottom.Controls.Add(this.like);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.trackBar1);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.play);
            this.panelBottom.Controls.Add(this.button9);
            this.panelBottom.Controls.Add(this.button7);
            this.panelBottom.Controls.Add(this.phonograph);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(185, 594);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(683, 51);
            this.panelBottom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "音量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(628, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "50%";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(533, 11);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "顺序播放";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(335, 25);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(20, 18);
            this.play.TabIndex = 8;
            this.play.Text = "◀";
            this.play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::MusicPlayerDemo.Properties.Resources._6908877_forward_music_next_play_rounded_icon;
            this.button9.Location = new System.Drawing.Point(379, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 5;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::MusicPlayerDemo.Properties.Resources._6908880_back_direction_music_play_previous_icon;
            this.button7.Location = new System.Drawing.Point(288, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // phonograph
            // 
            this.phonograph.BackgroundImage = global::MusicPlayerDemo.Properties.Resources._4168551_design_disc_dj_phonograph_producstion_icon;
            this.phonograph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phonograph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phonograph.Location = new System.Drawing.Point(39, 1);
            this.phonograph.Name = "phonograph";
            this.phonograph.Size = new System.Drawing.Size(56, 51);
            this.phonograph.TabIndex = 0;
            this.phonograph.TabStop = false;
            this.phonograph.Click += new System.EventHandler(this.phonograph_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.CausesValidation = false;
            this.panelCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(868, 645);
            this.panelCenter.TabIndex = 3;
            // 
            // like
            // 
            this.like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.like.FlatAppearance.BorderSize = 0;
            this.like.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.like.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.like.Image = global::MusicPlayerDemo.Properties.Resources._5172567_heart_like_love_icon;
            this.like.Location = new System.Drawing.Point(101, 19);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(30, 30);
            this.like.TabIndex = 14;
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 645);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonograph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Reduce;
        private System.Windows.Forms.PictureBox phonograph;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button myCollection;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button like;
    }
}

