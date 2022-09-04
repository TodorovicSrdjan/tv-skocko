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
using static TVSkocko_872019.SymbolValue;

namespace TVSkocko_872019
{
    public partial class Game : FormWithBackgroundMusic
    {
        private readonly Form parentForm;
        private readonly int ncols = 4;
        private readonly int nrows = 6;
        private readonly Bitmap EMPTY_LEFT = Resources.EmptyLeft;
        private readonly Bitmap EMPTY_RIGHT = Resources.EmptyRight;
        private readonly Symbol[] SYMBOLS = Symbol.Values();

        private int currentRow;
        private int currentColumn;

        public Game(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            
            Button b;
            TableLayoutPanelCellPosition pos;
            for (int i = 0; i < SYMBOLS.Length; i++)
            {
                b = new SymbolButton(this, SYMBOLS[i], i);
                pos = new TableLayoutPanelCellPosition(i, 0);
                this.gridSymbols.SetCellPosition(b, pos);
                this.gridSymbols.Controls.Add(b);
            }

            InitializeGame();
        }

        private void InitializeGame()
        {
            currentRow = 0;
            currentColumn = 0;

            this.Enabled = false;
            this.gridLeft.Visible = false;
            this.gridRight.Visible = false;
            this.Update();

            this.gridLeft.Controls.Clear();
            this.gridRight.Controls.Clear();

            Panel p;
            TableLayoutPanelCellPosition pos;
            for (int i = 0; i < ncols; i++)
            {
                for (int j = 0; j < nrows; j++)
                {
                    p = new GridCell(EMPTY_LEFT);
                    pos = new TableLayoutPanelCellPosition(i, j);
                    this.gridLeft.SetCellPosition(p, pos);
                    this.gridLeft.Controls.Add(p);

                    p = new GridCell(EMPTY_RIGHT);
                    pos = new TableLayoutPanelCellPosition(i, j);
                    this.gridRight.SetCellPosition(p, pos);
                    this.gridRight.Controls.Add(p);
                }
            }

            this.gridLeft.Visible = true;
            this.gridRight.Visible = true;
            this.Enabled = true;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show(Resources.GameExitWinMsg, Resources.GameExitWinTitle, MessageBoxButtons.YesNo))
            {
                e.Cancel = true;
            }   
            else
            {
                parentForm.Show();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            
            }

        internal void MakeMove(Symbol symbol)
        {
            Console.WriteLine($"Chosen symbol: {symbol}");
            if(currentColumn == ncols)
            {
                currentColumn = 0;
                currentRow++;
            }

            if(currentRow < nrows)
            {
                GridCell gc = (GridCell) this.gridLeft.GetControlFromPosition(currentColumn, currentRow);

                

                gc.Background = symbol;
                gc.Update();

                currentColumn++;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
