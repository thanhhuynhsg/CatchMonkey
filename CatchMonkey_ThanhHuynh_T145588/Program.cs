using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMonkey_ThanhHuynh_T145588
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PlayGame abc = new PlayGame();
            Application.Run(abc);
            Application.Run(new ListScores(abc.score()));
           
        }
    }
}
