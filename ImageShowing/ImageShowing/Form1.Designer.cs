namespace ImageShowing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.but_SlidesShow = new System.Windows.Forms.Button();
            this.but_Forword = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.but_SlideStop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picbx = new System.Windows.Forms.PictureBox();
            this.but_open = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBox
            // 
            this.panelBox.Controls.Add(this.label1);
            this.panelBox.Controls.Add(this.but_SlidesShow);
            this.panelBox.Controls.Add(this.but_Forword);
            this.panelBox.Controls.Add(this.but_back);
            this.panelBox.Controls.Add(this.but_SlideStop);
            this.panelBox.Controls.Add(this.pictureBox2);
            this.panelBox.Controls.Add(this.linkLabel3);
            this.panelBox.Controls.Add(this.linkLabel2);
            this.panelBox.Controls.Add(this.linkLabel1);
            this.panelBox.Controls.Add(this.pictureBox4);
            this.panelBox.Controls.Add(this.pictureBox3);
            this.panelBox.Controls.Add(this.picbx);
            this.panelBox.Location = new System.Drawing.Point(15, 115);
            this.panelBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(532, 567);
            this.panelBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "For More Pictures Press Any Key ";
            // 
            // but_SlidesShow
            // 
            this.but_SlidesShow.Location = new System.Drawing.Point(157, 232);
            this.but_SlidesShow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_SlidesShow.Name = "but_SlidesShow";
            this.but_SlidesShow.Size = new System.Drawing.Size(87, 69);
            this.but_SlidesShow.TabIndex = 14;
            this.but_SlidesShow.Text = "►";
            this.but_SlidesShow.UseVisualStyleBackColor = true;
            this.but_SlidesShow.Click += new System.EventHandler(this.but_SlidesShow_Click);
            // 
            // but_Forword
            // 
            this.but_Forword.Location = new System.Drawing.Point(407, 232);
            this.but_Forword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_Forword.Name = "but_Forword";
            this.but_Forword.Size = new System.Drawing.Size(87, 69);
            this.but_Forword.TabIndex = 13;
            this.but_Forword.Text = ">>";
            this.but_Forword.UseVisualStyleBackColor = true;
            this.but_Forword.Click += new System.EventHandler(this.but_Forword_Click);
            // 
            // but_back
            // 
            this.but_back.Location = new System.Drawing.Point(32, 232);
            this.but_back.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(87, 69);
            this.but_back.TabIndex = 12;
            this.but_back.Text = "<<";
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // but_SlideStop
            // 
            this.but_SlideStop.Location = new System.Drawing.Point(276, 232);
            this.but_SlideStop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_SlideStop.Name = "but_SlideStop";
            this.but_SlideStop.Size = new System.Drawing.Size(87, 69);
            this.but_SlideStop.TabIndex = 11;
            this.but_SlideStop.Text = "█";
            this.but_SlideStop.UseVisualStyleBackColor = true;
            this.but_SlideStop.Click += new System.EventHandler(this.but_SlideStop_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImageShowing.Properties.Resources.facebook_icon;
            this.pictureBox2.Location = new System.Drawing.Point(48, 409);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(398, 510);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(116, 24);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Instagram";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(235, 510);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(80, 24);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Google";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 510);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 24);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FaceBook";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ImageShowing.Properties.Resources.instagram_3955027;
            this.pictureBox4.Location = new System.Drawing.Point(402, 409);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ImageShowing.Properties.Resources.google_symbol_2875404;
            this.pictureBox3.Location = new System.Drawing.Point(225, 409);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // picbx
            // 
            this.picbx.Location = new System.Drawing.Point(32, 14);
            this.picbx.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.picbx.Name = "picbx";
            this.picbx.Size = new System.Drawing.Size(470, 176);
            this.picbx.TabIndex = 0;
            this.picbx.TabStop = false;
            // 
            // but_open
            // 
            this.but_open.Location = new System.Drawing.Point(15, 25);
            this.but_open.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_open.Name = "but_open";
            this.but_open.Size = new System.Drawing.Size(259, 80);
            this.but_open.TabIndex = 1;
            this.but_open.Text = "Open";
            this.but_open.UseVisualStyleBackColor = true;
            this.but_open.Click += new System.EventHandler(this.but_open_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(286, 25);
            this.but_close.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(261, 80);
            this.but_close.TabIndex = 2;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.bou_close_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "%D8%A7%D8%AC%D9%85%D9%84+%D8%AE%D9%84%D9%81%D9%8A%D8%A7%D8%AA+%D9%84%D8%A7%D8%A8+" +
        "%D8%AA%D9%88%D8%A8+%D8%A8%D8%A7%D8%B9%D9%84%D9%89+%D8%AC%D9%88%D8%AF%D8%A9+best+" +
        "wallpapers+for+pc+%2896%29.jpg");
            this.imageList.Images.SetKeyName(1, "4-iphone-anime-girl-wallpapers-hd-خلفيات-انمى-ايفون-أيفون-1-1024x699.jpg");
            this.imageList.Images.SetKeyName(2, "24-desktop-wallpapers-hd-4k-صور-خلفيات-كمبيوتر-سطح-المكتب.jpg");
            this.imageList.Images.SetKeyName(3, "17263.jpeg");
            this.imageList.Images.SetKeyName(4, "1089089.jpg");
            this.imageList.Images.SetKeyName(5, "1415341ccfe91ddde6c5094a3c03ede4.jpg");
            this.imageList.Images.SetKeyName(6, "f1df368de83376e8a0fbfbe7b50614fb.jpg");
            this.imageList.Images.SetKeyName(7, "WhatsApp-Image-2022-01-11-at-12.58.29-AM-2.jpeg");
            this.imageList.Images.SetKeyName(8, "أجمل-خلفيات-سطح-المكتب-خلفيات-لاب-توب-كيوت-2021-4.jpg");
            this.imageList.Images.SetKeyName(9, "اجمل-صور-خلفيات-كمبيوتر-HD-بجودة-عالية-2020،-صور-خلفيات-موبايل-متنوعة-2021-13-sca" +
        "led.jpg");
            this.imageList.Images.SetKeyName(10, "رمزيات-خلفيات-حلوة-للكمبيوتر-و-اللاب-توب-2-800x450.jpg");
            this.imageList.Images.SetKeyName(11, "رمزيات-و-خلفيات-HD-1.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 701);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_open);
            this.Controls.Add(this.panelBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBox.ResumeLayout(false);
            this.panelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBox;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picbx;
        private System.Windows.Forms.Button but_open;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button but_SlidesShow;
        private System.Windows.Forms.Button but_Forword;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Button but_SlideStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

