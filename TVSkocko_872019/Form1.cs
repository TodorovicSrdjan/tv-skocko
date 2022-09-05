using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    public partial class Form1 : FormWithBackgroundMusic
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Get player's name
            this.Hide();
            if (File.Exists(Settings.Default.GameSavePath))
            {
                var answer = MessageBox.Show(Resources.GameSaveMsg, Resources.GameSaveTitle, MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    StartTheGame();
                    return;
                }

                File.Delete(Settings.Default.GameSavePath);
            }

            Form inputForm = new frmPlayerName(this);
            inputForm.Show();
        }

        private void btnRankList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rankForm = new frmRank(this);
            rankForm.Show();
        }

        public void StartTheGame()
        {
            var gameForm = new Game(this);
            gameForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
