using System.Windows.Forms;

namespace TVSkocko_872019
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gridSymbols = new System.Windows.Forms.TableLayoutPanel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gridLeft = new System.Windows.Forms.TableLayoutPanel();
            this.gridRight = new System.Windows.Forms.TableLayoutPanel();
            this.gameDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnGuess = new System.Windows.Forms.Button();
            this.gridSolution = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowSolution = new System.Windows.Forms.Button();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gridSymbols
            // 
            this.gridSymbols.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridSymbols.ColumnCount = 6;
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.Location = new System.Drawing.Point(143, 16);
            this.gridSymbols.Name = "gridSymbols";
            this.gridSymbols.RowCount = 1;
            this.gridSymbols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.gridSymbols.Size = new System.Drawing.Size(246, 40);
            this.gridSymbols.TabIndex = 0;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(144)))));
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnUndo.Location = new System.Drawing.Point(22, 28);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(92, 54);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Poništi poslednji odabir";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedo.Enabled = false;
            this.btnRedo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(144)))));
            this.btnRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold);
            this.btnRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnRedo.Location = new System.Drawing.Point(412, 28);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(92, 54);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.Text = "Vrati poslednji odabir";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnNewGame.Location = new System.Drawing.Point(111, 381);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(92, 46);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Nova igra";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // gridLeft
            // 
            this.gridLeft.BackgroundImage = global::TVSkocko_872019.Properties.Resources.EmptyLeft;
            this.gridLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridLeft.ColumnCount = 4;
            this.gridLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridLeft.Location = new System.Drawing.Point(50, 100);
            this.gridLeft.Name = "gridLeft";
            this.gridLeft.Padding = new System.Windows.Forms.Padding(1);
            this.gridLeft.RowCount = 6;
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridLeft.Size = new System.Drawing.Size(175, 261);
            this.gridLeft.TabIndex = 0;
            // 
            // gridRight
            // 
            this.gridRight.BackgroundImage = global::TVSkocko_872019.Properties.Resources.EmptyRight;
            this.gridRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridRight.ColumnCount = 4;
            this.gridRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridRight.Location = new System.Drawing.Point(307, 100);
            this.gridRight.Name = "gridRight";
            this.gridRight.Padding = new System.Windows.Forms.Padding(1);
            this.gridRight.RowCount = 6;
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridRight.Size = new System.Drawing.Size(175, 261);
            this.gridRight.TabIndex = 1;
            // 
            // gameDurationTimer
            // 
            this.gameDurationTimer.Enabled = true;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(104)))), ((int)(((byte)(35)))));
            this.btnGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(80)))), ((int)(((byte)(27)))));
            this.btnGuess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(78)))));
            this.btnGuess.Location = new System.Drawing.Point(225, 64);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(82, 30);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Pokušaj";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Visible = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // gridSolution
            // 
            this.gridSolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridSolution.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridSolution.ColumnCount = 4;
            this.gridSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gridSolution.Location = new System.Drawing.Point(179, 50);
            this.gridSolution.Name = "gridSolution";
            this.gridSolution.Padding = new System.Windows.Forms.Padding(1);
            this.gridSolution.RowCount = 1;
            this.gridSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridSolution.Size = new System.Drawing.Size(175, 46);
            this.gridSolution.TabIndex = 1;
            this.gridSolution.Visible = false;
            // 
            // btnShowSolution
            // 
            this.btnShowSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnShowSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSolution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.btnShowSolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnShowSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSolution.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnShowSolution.Location = new System.Drawing.Point(221, 381);
            this.btnShowSolution.Name = "btnShowSolution";
            this.btnShowSolution.Size = new System.Drawing.Size(92, 46);
            this.btnShowSolution.TabIndex = 5;
            this.btnShowSolution.Text = "Prikaži rešenje";
            this.btnShowSolution.UseVisualStyleBackColor = false;
            this.btnShowSolution.Click += new System.EventHandler(this.btnShowSolution_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSolution.Font = new System.Drawing.Font("DejaVu Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.lblSolution.Location = new System.Drawing.Point(194, 12);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(145, 34);
            this.lblSolution.TabIndex = 0;
            this.lblSolution.Text = "Rešenje";
            this.lblSolution.Visible = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnMainMenu.Location = new System.Drawing.Point(333, 381);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(92, 46);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Glavni meni";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayerName.Font = new System.Drawing.Font("DejaVu Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(78)))));
            this.lblPlayerName.Location = new System.Drawing.Point(50, 453);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(430, 40);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TVSkocko_872019.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 493);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnShowSolution);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.gridSymbols);
            this.Controls.Add(this.gridRight);
            this.Controls.Add(this.gridLeft);
            this.Controls.Add(this.gridSolution);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skočko";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.TableLayoutPanel gridLeft;
        private System.Windows.Forms.TableLayoutPanel gridRight;
        private System.Windows.Forms.TableLayoutPanel gridSymbols;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private Button btnNewGame;
        private Timer gameDurationTimer;
        private Button btnGuess;
        private TableLayoutPanel gridSolution;
        private Button btnShowSolution;
        private Label lblSolution;
        private Button btnMainMenu;
        private Label lblPlayerName;
    }
}