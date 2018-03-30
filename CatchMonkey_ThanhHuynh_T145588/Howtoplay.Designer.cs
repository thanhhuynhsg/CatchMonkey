namespace CatchMonkey_ThanhHuynh_T145588
{
    partial class Howtoplay
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
            this.btnok = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(191, 61);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(69, 26);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(262, 49);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "When starting the game, you use the mouse to click on the monkey on the screen, i" +
    "f you click on the bomb or time up you will lose.";
            // 
            // Howtoplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 92);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnok);
            this.Name = "Howtoplay";
            this.Text = "How to play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbl;
    }
}