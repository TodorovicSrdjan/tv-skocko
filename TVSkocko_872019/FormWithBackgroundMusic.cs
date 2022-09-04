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
        protected Timer timer1;

        public FormWithBackgroundMusic()
        {
            songInfoInWindowTitle = $"{Resources.background_song_info}    ";
            this.Text = $"{Resources.window_title}: {songInfoInWindowTitle}";
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
            this.Text = $"{Resources.window_title}: {songInfoInWindowTitle}";
        }

        public void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500; // in miliseconds
            timer1.Start();
        }
    }
}
