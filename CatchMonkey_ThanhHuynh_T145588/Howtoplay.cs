using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMonkey_ThanhHuynh_T145588
{
    public partial class Howtoplay : Form
    {
        public Howtoplay()
        {
            InitializeComponent();
            this.lbl.Text = "When starting the game, you use the mouse to click on the monkey on the screen, if you click on the bomb or time up you will lose.";
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
