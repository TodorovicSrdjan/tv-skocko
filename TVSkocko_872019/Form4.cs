using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVSkocko_872019
{
    public partial class frmRank : FormWithBackgroundMusic
    {
        private readonly Form1 parentForm;
        private readonly DatabaseUtil databaseUtil = new DatabaseUtil();

        public frmRank(Form1 parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
            InitializeScoresGrid();
        }

        private void InitializeScoresGrid()
        {
            var scores = databaseUtil.GetTopTenScores();
            if (scores != null)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    var index = dgvScores.Rows.Add();
                    dgvScores.Rows[index].Cells["Rank"].Value = i+1;
                    dgvScores.Rows[index].Cells["PlayerName"].Value = scores[i].PlayerName;
                    dgvScores.Rows[index].Cells["Score"].Value = scores[i].Score;
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
