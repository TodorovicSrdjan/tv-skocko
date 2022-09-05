using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSkocko_872019.Properties;

namespace TVSkocko_872019
{
    public partial class frmPlayerName : Form
    {
        private Form1 parentForm;
        public frmPlayerName(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartTheGame();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StartTheGame();
        }

        private void StartTheGame()
        {
            Settings.Default.PlayerName = this.tbUserInput.Text;
            parentForm.StartTheGame();
            this.Close();
        }
    }
}
