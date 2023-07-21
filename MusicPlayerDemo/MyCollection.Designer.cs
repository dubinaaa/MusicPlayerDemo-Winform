namespace MusicPlayerDemo
{
    partial class MyCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.myCollectionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(214, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "我的收藏列表：";
            // 
            // myCollectionListBox
            // 
            this.myCollectionListBox.AccessibleName = "";
            this.myCollectionListBox.BackColor = System.Drawing.Color.White;
            this.myCollectionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myCollectionListBox.FormattingEnabled = true;
            this.myCollectionListBox.ItemHeight = 15;
            this.myCollectionListBox.Location = new System.Drawing.Point(290, 104);
            this.myCollectionListBox.Name = "myCollectionListBox";
            this.myCollectionListBox.Size = new System.Drawing.Size(510, 345);
            this.myCollectionListBox.TabIndex = 2;
            this.myCollectionListBox.SelectedIndexChanged += new System.EventHandler(this.myCollectionListBox_SelectedIndexChanged);
            // 
            // MyCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myCollectionListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyCollection";
            this.Text = "MyCollection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox myCollectionListBox;
    }
}