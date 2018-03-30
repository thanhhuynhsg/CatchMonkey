namespace CatchMonkey_ThanhHuynh_T145588
{
    partial class ListScores
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
            this.lblscores = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblscores
            // 
            this.lblscores.AutoSize = true;
            this.lblscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscores.ForeColor = System.Drawing.Color.Red;
            this.lblscores.Location = new System.Drawing.Point(53, 9);
            this.lblscores.Name = "lblscores";
            this.lblscores.Size = new System.Drawing.Size(131, 26);
            this.lblscores.TabIndex = 2;
            this.lblscores.Text = "List Scores";
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(12, 38);
            this.txtscore.Multiline = true;
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(241, 331);
            this.txtscore.TabIndex = 3;
            this.txtscore.Visible = false;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(0, 38);
            this.txtscore2.Multiline = true;
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(252, 331);
            this.txtscore2.TabIndex = 4;
            // 
            // ListScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 353);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.lblscores);
            this.Name = "ListScores";
            this.Text = "List Scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.highscores_FormClosing);
            //this.Load += new System.EventHandler(this.ListScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscores;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtscore2;
    }
}