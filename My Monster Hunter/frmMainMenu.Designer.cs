namespace My_Monster_Hunter
{
    partial class frmMainMenu
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblMapSelection = new System.Windows.Forms.Label();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.lblErreurNbrChar = new System.Windows.Forms.Label();
            this.lblMapUnselected = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(163, 329);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 66);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(391, 329);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(204, 66);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(274, 196);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(204, 22);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(176, 199);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(89, 16);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // lblMapSelection
            // 
            this.lblMapSelection.AutoSize = true;
            this.lblMapSelection.Location = new System.Drawing.Point(177, 240);
            this.lblMapSelection.Name = "lblMapSelection";
            this.lblMapSelection.Size = new System.Drawing.Size(96, 16);
            this.lblMapSelection.TabIndex = 4;
            this.lblMapSelection.Text = "Map Selection:";
            // 
            // cmbMaps
            // 
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(274, 237);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(204, 24);
            this.cmbMaps.TabIndex = 5;
            // 
            // lblErreurNbrChar
            // 
            this.lblErreurNbrChar.AutoSize = true;
            this.lblErreurNbrChar.Location = new System.Drawing.Point(498, 199);
            this.lblErreurNbrChar.Name = "lblErreurNbrChar";
            this.lblErreurNbrChar.Size = new System.Drawing.Size(267, 16);
            this.lblErreurNbrChar.TabIndex = 6;
            this.lblErreurNbrChar.Text = "Name must be between 1 and 20 characters";
            // 
            // lblMapUnselected
            // 
            this.lblMapUnselected.AutoSize = true;
            this.lblMapUnselected.Location = new System.Drawing.Point(498, 240);
            this.lblMapUnselected.Name = "lblMapUnselected";
            this.lblMapUnselected.Size = new System.Drawing.Size(130, 16);
            this.lblMapUnselected.TabIndex = 7;
            this.lblMapUnselected.Text = "Please select a map";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 493);
            this.Controls.Add(this.lblMapUnselected);
            this.Controls.Add(this.lblErreurNbrChar);
            this.Controls.Add(this.cmbMaps);
            this.Controls.Add(this.lblMapSelection);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmMainMenu";
            this.Text = "Monster Hunter";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblMapSelection;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.Label lblErreurNbrChar;
        private System.Windows.Forms.Label lblMapUnselected;
        private System.Windows.Forms.Timer timer1;
    }
}

