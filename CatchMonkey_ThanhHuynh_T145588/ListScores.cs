using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CatchMonkey_ThanhHuynh_T145588
{
    public partial class ListScores : Form
    {
        PlayGame n = new PlayGame();

        string s1 = "score.txt";

        int[] lst1;

        public ListScores(string r)
        {
            InitializeComponent();
            this.txtscore.Text = ReadFile() + "\r\n" + r;

            string txt = txtscore.Text;
            string[] lst = txt.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            lst1 = new int[100];
            for (int h = 0; h<lst.Length; h++)
            {
                 lst1[h] = int.Parse(lst[h].ToString());
            }

            Array.Sort(lst1, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            string n = "";
            for (int k = 0; k < lst.Length; k++ ) 
            {
                n = n + lst1[k] + "\r\n";
            }
            this.txtscore2.Text = n;
            txtscore2.Visible = true;
        }

        public string ReadFile()
        {
            StreamReader reader = new StreamReader(s1);
            String s2 = reader.ReadToEnd();
            if (reader.EndOfStream == true)
            {
                reader.Close();
            }
            return s2;
        }

        private void highscores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText("score.txt", txtscore2.Text);
            }
            else
            {
                e.Cancel = true;
            }
        }


        
    }
}
