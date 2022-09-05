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
    public enum GuessResultValue { MATCH, SEMI_MATCH, MISMATCH };
    public partial class Game : FormWithBackgroundMusic
    {
        private readonly Form parentForm;
        private readonly int ncols = 4;
        private readonly int nrows = 6;
        private readonly Bitmap EMPTY_LEFT = Resources.EmptyLeft;
        private readonly Bitmap EMPTY_RIGHT = Resources.EmptyRight;
        private readonly Symbol[] SYMBOLS = Symbol.Values();
        private Func<GuessResultValue, bool> checkIfSolutionIsFound = delegate (GuessResultValue guessResultValue)
        {
            return guessResultValue.Equals(GuessResultValue.MATCH);
        };

        private int currentRow;
        private int currentColumn;
        private GameHistory history;
        private Symbol[] solution;

        public Game(Form parentForm)
        {
            InitializeComponent();

            history = new GameHistory();
            this.parentForm = parentForm;
            
            // Add grid of symbol buttons
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
            this.lblSolution.Visible = false;
            this.gridSolution.Visible = false;
            this.gridSymbols.Visible = true;
            this.btnUndo.Visible = true;
            this.btnRedo.Visible = true;
            this.btnShowSolution.Visible = true;

            currentRow = 0;
            currentColumn = 0;
            solution = CreateSolution();

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

        private Symbol[] CreateSolution()
        {
            Symbol[] solution = new Symbol[ncols];
            Random r = new Random();
            String solutionStr = "";

            for (int i = 0; i < ncols; i++)
            {
                solution[i] = SYMBOLS[r.Next(SYMBOLS.Length)];
                solutionStr += $"{solution[i]} ";
            }

            Console.WriteLine($"Created solution for this game is: {solutionStr}");

            // Add solution to solution grid
            GridCell gc;
            TableLayoutPanelCellPosition pos;
            for (int i = 0; i < ncols; i++)
            {
                gc = new GridCell(solution[i]);
                pos = new TableLayoutPanelCellPosition(i, 0);
                this.gridSolution.SetCellPosition(gc, pos);
                this.gridSolution.Controls.Add(gc);
            }

            return solution;
        }

        private GuessResultValue[] CheckGuess(Symbol[] guess)
        {
            int numOfSemiMatches = 0;
            int guessResultCurrIndex = 0;
            GuessResultValue[] guessResult = new GuessResultValue[ncols];
            String guessResultStr = "";

            List<Symbol> mismatchGuess = new List<Symbol>();
            List<Symbol> mismatchSolution = new List<Symbol>();

            for (int i = 0; i < guess.Length; i++)
            {
                // Check if i-th symbol is exect match
                if (guess[i].Equals(solution[i]))
                {
                    guessResult[guessResultCurrIndex++] = GuessResultValue.MATCH;
                    guessResultStr += $"{GuessResultValue.MATCH} ";
                }
                else
                {
                    mismatchGuess.Add(guess[i]);
                    mismatchSolution.Add(solution[i]);
                }
            }

            mismatchGuess.Sort();
            mismatchSolution.Sort();

            for (int g = 0, s = 0; g < mismatchGuess.Count && s < mismatchSolution.Count; )
            {
                if ( -1 == mismatchGuess[g].CompareTo(mismatchSolution[s]))
                    g++;
                else if (1 == mismatchGuess[g].CompareTo(mismatchSolution[s]))
                    s++;
                else
                {
                    g++;
                    s++;
                    numOfSemiMatches++;
                }
            }

            // Fill array with occurences of semi_match
            for (int i = guessResultCurrIndex; i < guessResultCurrIndex+numOfSemiMatches; i++)
            {
                guessResult[i] = GuessResultValue.SEMI_MATCH;
                guessResultStr += $"{GuessResultValue.SEMI_MATCH} ";
            }

            // Fill the rest of the array with mismatch values
            for (int i = guessResultCurrIndex + numOfSemiMatches; i < ncols; i++)
            {
                guessResult[i] = GuessResultValue.MISMATCH;
                guessResultStr += $"{GuessResultValue.MISMATCH} ";
            }

            Console.WriteLine($"Guess result: {guessResultStr}");

            return guessResult;
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
        #region Game state managment
        private void RecoverPreviousState(GameState state)
        {
            currentRow = state.IndexOfCurrentRow;
            currentColumn = state.IndexOfCurrentColumn;
        }
        
        private GameState SaveGameState(Symbol symbol)
        {
            GameState state = new GameState();
            state.IndexOfCurrentRow = currentRow;
            state.IndexOfCurrentColumn = currentColumn;
            state.ChosenSymbol = symbol;

            return state;
        }
        
        private void UpdateStateComponents()
        {
            if (history.HasPrevious())
                this.btnUndo.Enabled = true;
            else
                this.btnUndo.Enabled = false;

            if (history.HasNext())
                this.btnRedo.Enabled = true;
            else
                this.btnRedo.Enabled = false;

            // Check if row is populated
            if (currentColumn == ncols)
                this.btnGuess.Visible = true;
            else
                this.btnGuess.Visible = false;
        }


        private void UndoMove()
        {
            RecoverPreviousState(history.SelectPreviousState());

            // Remove symbol content
            var gc = (GridCell)this.gridLeft.GetControlFromPosition(currentColumn, currentRow);
            gc.SymbolContent = null;
            gc.Background = EMPTY_LEFT;
            gc.Update();

            UpdateStateComponents();
        }
        private void RedoMove()
        {
            var nextState = history.SelectNextState();
            RecoverPreviousState(nextState);

            // Remove symbol content
            var gc = (GridCell)this.gridLeft.GetControlFromPosition(currentColumn, currentRow);
            gc.SymbolContent = nextState.ChosenSymbol;
            gc.Background = nextState.ChosenSymbol;
            gc.Update();
            currentColumn++;

            UpdateStateComponents();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoMove();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            RedoMove();
        }
        #endregion

        private void UpdateRightGrid(GuessResultValue[] guessResultValues)
        {
            for (int i = 0; i < ncols; i++)
            {
                var gc = (GridCell)this.gridRight.GetControlFromPosition(i, currentRow);

                switch (guessResultValues[i])
                {
                    case GuessResultValue.MATCH:
                        gc.Background = Resources.Match;
                        break;
                    case GuessResultValue.SEMI_MATCH:
                        gc.Background = Resources.SemiMatch;
                        break;
                    case GuessResultValue.MISMATCH:
                        break;
                }

                gc.Update();
            }
        }

        internal void MakeMove(Symbol symbol)
        {
            // Check if it's last move in the row
            if (currentColumn == ncols)
                return;

            this.btnUndo.Enabled = true;
            Console.WriteLine($"Chosen symbol for position ({currentRow},{currentColumn}): {symbol}");

            // Make a move
            var gc = (GridCell)this.gridLeft.GetControlFromPosition(currentColumn, currentRow);
            gc.SymbolContent = symbol;
            gc.Background = symbol;
            gc.Update();
            history.AddNewState(SaveGameState(symbol));

            currentColumn++;

            UpdateStateComponents();

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Guess is made //

            // Extract guess from left grid
            var guess = new Symbol[ncols];
            for (int i = 0; i < ncols; i++)
            {
                var control = ((GridCell)this.gridLeft.GetControlFromPosition(i, currentRow));
                guess[i] = control.SymbolContent;
            }

            // Check player's guess
            var guessResult = CheckGuess(guess);

            UpdateRightGrid(guessResult);

            currentColumn = 0;
            currentRow++;

            history.Clear();
            UpdateStateComponents();

            // Check if player guessed correctly
            if (ncols == guessResult.Count(checkIfSolutionIsFound))
            {
                MessageBox.Show(Resources.GameSuccessMsg, Resources.GameSuccessTitle, MessageBoxButtons.OK);
                this.gridSymbols.Visible = false;
                this.btnShowSolution.Visible = false;
                this.btnUndo.Visible = false;
                this.btnRedo.Visible = false;
            }
            // Check if player has used all available guess attempts
            else if (currentRow == nrows)
            {
                MessageBox.Show(Resources.EndGameMaxAttemptsMsg, Resources.EndGameMaxAttemptsTitle, MessageBoxButtons.OK);
                this.gridSymbols.Visible = false;
                this.btnUndo.Visible = false;
                this.btnRedo.Visible = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void btnShowSolution_Click(object sender, EventArgs e)
        {
            this.btnShowSolution.Visible = false;
            this.gridSymbols.Visible = false;
            this.btnUndo.Visible = false;
            this.btnRedo.Visible = false;
            this.gridSolution.Visible = true;
            this.lblSolution.Visible = true;
        }
    }
}
