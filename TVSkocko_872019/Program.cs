using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Settings.Default.GameSavePath = String.Format(@"{0}\savefile.xml", Application.StartupPath);

            // Start music in the background
            SoundPlayer player = new SoundPlayer(Resources.background_song);
            player.PlayLooping();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
