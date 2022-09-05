namespace TVSkocko_872019
{
    partial class frmPlayerName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerName));
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserInput
            // 
            this.tbUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.tbUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserInput.Font = new System.Drawing.Font("DejaVu Sans", 16F, System.Drawing.FontStyle.Bold);
            this.tbUserInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.tbUserInput.Location = new System.Drawing.Point(35, 87);
            this.tbUserInput.MaxLength = 30;
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(304, 32);
            this.tbUserInput.TabIndex = 0;
            this.tbUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("DejaVu Sans", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.lblPlayerName.Location = new System.Drawing.Point(38, 41);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(298, 34);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Unesite Vaše ime";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(190)))), ((int)(((byte)(159)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.btnNext.Location = new System.Drawing.Point(141, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Dalje";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPlayerName
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(125)))), ((int)(((byte)(120)))));
            this.BackgroundImage = global::TVSkocko_872019.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(368, 174);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbUserInput);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlayerName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInput";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserInput;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnNext;
    }
}