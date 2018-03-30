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
    
    public partial class PlayGame : Form
    {
        Random rd = new Random();
        int i = 0, j = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, c1 = 0, c2 = 0;

        int[] arr1 = { 12, 168, 320 };
        int[] arr2 = { 122, 231, 345, 468, 583 };

        int count = 0;
        public int sumscore = 0;
     
        private int SecondsLeft;
        private int time;
        private int time1 = 10;

        public PlayGame()
        {
            InitializeComponent();
            picclock.Visible = false;
            timeX = new Timer() { Interval = 1000 };
            timeX.Tick += new EventHandler(timeX_Tick);

            timerclock = new Timer() { Interval = 400 };
            timerclock.Tick += new EventHandler(timerclock_Tick);

            mainpicture.Controls.Add(picmonkey);
            mainpicture.Controls.Add(picplay);
            mainpicture.Controls.Add(picclock);
            mainpicture.Controls.Add(picbomb1);
            mainpicture.Controls.Add(picbomb2);

        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            if (count > 3)
            {
                timeX.Stop();
                maintimer.Stop();
                timerclock.Stop();
                MessageBox.Show("You lose !\nMy Score: "+sumscore);
            }

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            this.lbldate.Text = month+"/"+day+"/"+year;

        }

        private void maintimer_Tick(object sender, EventArgs e)
        {
            i = rd.Next(0, 3);
            j = rd.Next(0, 5);
            b1 = rd.Next(0, 3);
            b2 = rd.Next(0, 5);
            b3 = rd.Next(0, 3);
            b4 = rd.Next(0, 5);
            c1 = rd.Next(0, 3);
            c2 = rd.Next(0, 5);

            picmonkey.Location = new Point(arr1[i], arr2[j]);

            if (b1 != i)
            {
                picbomb1.Location = new Point(arr1[b1], arr2[b2]);
            }
            if (b3 != i)
            {
                picbomb2.Location = new Point(arr1[b3], arr2[b4]);
            }
            //c1 != i && c2 != b2 && c2 != b4 && c1 != j
            if ((c1 != i && c2 != j) || (c1 != b1 && c2 != b2) || (c1 != b3 && c2 != b4))
            {
                if (time1 == 0)
                {
                    picclock.Visible = true;
                    picclock.Location = new Point(arr1[c1], arr2[c2]);
                }
            }
        }


        private void mainpicture_Click(object sender, EventArgs e)
        {
            count = count + 1;
            lbl1.Text = "Life: " + (4 - count);
            PlayGame_Load(sender, e);
        }
        
        private void timerclock_Tick(object sender, EventArgs e)
        {
            if (time1-- == 0)
            {
                time1 = 10;
            }
        }

        private void picplay_Click(object sender, EventArgs e)
        {
            maintimer.Start();
            SecondsLeft = 70;
            time = 10;
            timeX.Start();
            maintimer.Start();
            timerclock.Start();
            picplay.Visible = false;
            picbomb1.Visible = true;
            picbomb2.Visible = true;
            picmonkey.Visible = true;
        }

        private void picmonkey_Click(object sender, EventArgs e)
        {
            sumscore += 10;
            lblscore.Text = "Score: " + sumscore;
        }

        private void picreplay_Click(object sender, EventArgs e)
        {
            SecondsLeft = 70;
            time = 10;
            sumscore = 0;
            count = 0;
            lbl1.Text = "Life: 3";
            lblscore.Text = "Score: " + sumscore;
            timeX.Start();
            maintimer.Start();
            timerclock.Start();
        }

        private void timeX_Tick(object sender, EventArgs e)
        {
            if (SecondsLeft-- == 0)
            {
                timeX.Stop();
                maintimer.Stop();
                timerclock.Stop();
                lblscore.Visible = true;
                MessageBox.Show("Time Over \nMy Score: "+sumscore);
                lblscore.Text = "Score: 0";
            }
            if (time-- == 0)
            {
                time = 10;
            }
            lbltime.Text = "Time: " + SecondsLeft;
        }

        private void picclock_Click(object sender, EventArgs e)
        {
            SecondsLeft += 10;
            picclock.Visible = false;
        }

        private void picbomb2_Click(object sender, EventArgs e)
        {
            timeX.Stop();
            maintimer.Stop();
            timerclock.Stop();
            MessageBox.Show("You lose ! \nMy Score: "+sumscore);
        }

        private void picbomb1_Click(object sender, EventArgs e)
        {
            maintimer.Stop();
            timeX.Stop();
            timerclock.Stop();
            MessageBox.Show("You lose ! \nMy Score: "+sumscore);
        }

        public string score()
        {
            string n = sumscore.ToString();
            return n;
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Howtoplay how = new Howtoplay();
            how.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

    }
}
