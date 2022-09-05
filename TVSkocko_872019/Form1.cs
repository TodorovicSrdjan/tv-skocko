using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
