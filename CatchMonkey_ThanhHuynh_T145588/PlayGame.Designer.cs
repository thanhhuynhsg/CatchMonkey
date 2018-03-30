namespace CatchMonkey_ThanhHuynh_T145588
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.picreplay = new System.Windows.Forms.PictureBox();
            this.timeX = new System.Windows.Forms.Timer(this.components);
            this.lblscore = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.picbomb1 = new System.Windows.Forms.PictureBox();
            this.picclock = new System.Windows.Forms.PictureBox();
            this.picbomb2 = new System.Windows.Forms.PictureBox();
            this.picmonkey = new System.Windows.Forms.PictureBox();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.mainpicture = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.picplay = new System.Windows.Forms.PictureBox();
            this.lbldate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picreplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmonkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picplay)).BeginInit();
            this.SuspendLayout();
            // 
            // timerclock
            // 
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // picreplay
            // 
            this.picreplay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picreplay.ErrorImage")));
            this.picreplay.ImageLocation = "arrows.png";
            this.picreplay.Location = new System.Drawing.Point(12, 31);
            this.picreplay.Name = "picreplay";
            this.picreplay.Size = new System.Drawing.Size(34, 36);
            this.picreplay.TabIndex = 20;
            this.picreplay.TabStop = false;
            this.picreplay.Click += new System.EventHandler(this.picreplay_Click);
            // 
            // timeX
            // 
            this.timeX.Interval = 10;
            this.timeX.Tick += new System.EventHandler(this.timeX_Tick);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(298, 45);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(76, 20);
            this.lblscore.TabIndex = 21;
            this.lblscore.Text = "Score: 0";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(52, 45);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(77, 20);
            this.lbltime.TabIndex = 19;
            this.lbltime.Text = "Time: 70";
            // 
            // picbomb1
            // 
            this.picbomb1.BackColor = System.Drawing.Color.Transparent;
            this.picbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbomb1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbomb1.ErrorImage")));
            this.picbomb1.ImageLocation = "bomb.png";
            this.picbomb1.Location = new System.Drawing.Point(175, 470);
            this.picbomb1.Name = "picbomb1";
            this.picbomb1.Size = new System.Drawing.Size(66, 62);
            this.picbomb1.TabIndex = 18;
            this.picbomb1.TabStop = false;
            this.picbomb1.Visible = false;
            this.picbomb1.Click += new System.EventHandler(this.picbomb1_Click);
            // 
            // picclock
            // 
            this.picclock.BackColor = System.Drawing.Color.Transparent;
            this.picclock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picclock.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picclock.ErrorImage")));
            this.picclock.ImageLocation = "clock.png";
            this.picclock.Location = new System.Drawing.Point(164, 305);
            this.picclock.Name = "picclock";
            this.picclock.Size = new System.Drawing.Size(66, 69);
            this.picclock.TabIndex = 17;
            this.picclock.TabStop = false;
            this.picclock.Visible = false;
            this.picclock.Click += new System.EventHandler(this.picclock_Click);
            // 
            // picbomb2
            // 
            this.picbomb2.BackColor = System.Drawing.Color.Transparent;
            this.picbomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbomb2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbomb2.ErrorImage")));
            this.picbomb2.ImageLocation = "bomb.png";
            this.picbomb2.Location = new System.Drawing.Point(21, 227);
            this.picbomb2.Name = "picbomb2";
            this.picbomb2.Size = new System.Drawing.Size(65, 64);
            this.picbomb2.TabIndex = 16;
            this.picbomb2.TabStop = false;
            this.picbomb2.Visible = false;
            this.picbomb2.Click += new System.EventHandler(this.picbomb2_Click);
            // 
            // picmonkey
            // 
            this.picmonkey.BackColor = System.Drawing.Color.Transparent;
            this.picmonkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picmonkey.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picmonkey.ErrorImage")));
            this.picmonkey.ImageLocation = "monkey.png";
            this.picmonkey.Location = new System.Drawing.Point(21, 545);
            this.picmonkey.Name = "picmonkey";
            this.picmonkey.Size = new System.Drawing.Size(64, 59);
            this.picmonkey.TabIndex = 15;
            this.picmonkey.TabStop = false;
            this.picmonkey.Visible = false;
            this.picmonkey.Click += new System.EventHandler(this.picmonkey_Click);
            // 
            // maintimer
            // 
            this.maintimer.Interval = 650;
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // mainpicture
            // 
            this.mainpicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("mainpicture.ErrorImage")));
            this.mainpicture.ImageLocation = "main.png";
            this.mainpicture.Location = new System.Drawing.Point(0, 73);
            this.mainpicture.Name = "mainpicture";
            this.mainpicture.Size = new System.Drawing.Size(397, 545);
            this.mainpicture.TabIndex = 12;
            this.mainpicture.TabStop = false;
            this.mainpicture.Click += new System.EventHandler(this.mainpicture_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(171, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 20);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "Life: 3";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(397, 24);
            this.menu.TabIndex = 11;
            this.menu.Text = "menu";
            // 
            // picplay
            // 
            this.picplay.BackColor = System.Drawing.Color.Transparent;
            this.picplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picplay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picplay.ErrorImage")));
            this.picplay.ImageLocation = "play.png";
            this.picplay.InitialImage = ((System.Drawing.Image)(resources.GetObject("picplay.InitialImage")));
            this.picplay.Location = new System.Drawing.Point(136, 192);
            this.picplay.Name = "picplay";
            this.picplay.Size = new System.Drawing.Size(126, 126);
            this.picplay.TabIndex = 22;
            this.picplay.TabStop = false;
            this.picplay.Click += new System.EventHandler(this.picplay_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(286, 4);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(99, 20);
            this.lbldate.TabIndex = 23;
            this.lbldate.Text = "09/28/2016";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 618);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.picplay);
            this.Controls.Add(this.picreplay);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.picbomb1);
            this.Controls.Add(this.picclock);
            this.Controls.Add(this.picbomb2);
            this.Controls.Add(this.picmonkey);
            this.Controls.Add(this.mainpicture);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menu);
            this.Name = "PlayGame";
            this.Text = "Catch Monkey";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picreplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmonkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.PictureBox picreplay;
        private System.Windows.Forms.Timer timeX;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.PictureBox picbomb1;
        private System.Windows.Forms.PictureBox picclock;
        private System.Windows.Forms.PictureBox picbomb2;
        private System.Windows.Forms.PictureBox picmonkey;
        private System.Windows.Forms.Timer maintimer;
        private System.Windows.Forms.PictureBox mainpicture;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox picplay;
        private System.Windows.Forms.Label lbldate;
    }
}

