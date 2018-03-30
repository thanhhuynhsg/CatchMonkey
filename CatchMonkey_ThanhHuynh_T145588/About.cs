using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMonkey_ThanhHuynh_T145588
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About");
            this.labelProductName.Text = "Catch Monkey";
            this.labelVersion.Text = String.Format("Version 1.0");
            this.labelCopyright.Text = AssemblyCopyright + " - Thanh Huynh";
            this.textBoxDescription.Text = "Considering the game “Bắt Khỉ”, the Catch Monkeys application games simulate this game for running on computer. The application will display the monkey and you need quick hands touch them, selected items advantage from the game and win the highest score.";
        }

        #region Assembly Attribute Accessors
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
