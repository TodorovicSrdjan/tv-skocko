using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSkocko_872019.Properties;
using Timer = System.Windows.Forms.Timer;

namespace TVSkocko_872019
{
    public class FormWithBackgroundMusic : Form
    {
        protected String songInfoInWindowTitle;
        protected Timer slidingTextTimer;

        public FormWithBackgroundMusic()
        {
            songInfoInWindowTitle = $"{Resources.BackgroundSongInfo}    ";
            this.Text = $"{Resources.WindowTitle}: {songInfoInWindowTitle}";
            InitializeTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var chars = songInfoInWindowTitle.ToList();
            String newTxt = "";

            foreach (char c in chars.Take(chars.Count - 1).Prepend(chars.Last()))
            {
                newTxt += c;
            }

            songInfoInWindowTitle = newTxt;
            this.Text = $"{Resources.WindowTitle}: {songInfoInWindowTitle}";
        }

        public void InitializeTimer()
        {
            slidingTextTimer = new Timer();
            slidingTextTimer.Tick += new EventHandler(timer1_Tick);
            slidingTextTimer.Interval = 500; // in miliseconds
            slidingTextTimer.Start();
        }
    }
}
