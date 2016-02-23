namespace UgsApiTester
{
    partial class MainForm
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
            this.btnAuthorizePlayer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboServerBaseUrl = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOperator = new System.Windows.Forms.TabPage();
            this.tabGameProvider = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptAuthTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabOperator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuthorizePlayer
            // 
            this.btnAuthorizePlayer.Location = new System.Drawing.Point(22, 23);
            this.btnAuthorizePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorizePlayer.Name = "btnAuthorizePlayer";
            this.btnAuthorizePlayer.Size = new System.Drawing.Size(175, 41);
            this.btnAuthorizePlayer.TabIndex = 0;
            this.btnAuthorizePlayer.Text = "Authorize Player";
            this.btnAuthorizePlayer.UseVisualStyleBackColor = true;
            this.btnAuthorizePlayer.Click += new System.EventHandler(this.btnAuthorizePlayer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Server Base";
            // 
            // cboServerBaseUrl
            // 
            this.cboServerBaseUrl.FormattingEnabled = true;
            this.cboServerBaseUrl.Items.AddRange(new object[] {
            "http://integration-8-ugs-api.flycowdev.com",
            "http://integration-2-ugs-api.flycowdev.com",
            "http://staging.tgpaccess.com",
            "http://tgpaccess.com"});
            this.cboServerBaseUrl.Location = new System.Drawing.Point(122, 26);
            this.cboServerBaseUrl.Margin = new System.Windows.Forms.Padding(4);
            this.cboServerBaseUrl.Name = "cboServerBaseUrl";
            this.cboServerBaseUrl.Size = new System.Drawing.Size(399, 24);
            this.cboServerBaseUrl.TabIndex = 30;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOperator);
            this.tabControl1.Controls.Add(this.tabGameProvider);
            this.tabControl1.Location = new System.Drawing.Point(34, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 285);
            this.tabControl1.TabIndex = 32;
            // 
            // tabOperator
            // 
            this.tabOperator.Controls.Add(this.btnAuthorizePlayer);
            this.tabOperator.Location = new System.Drawing.Point(4, 25);
            this.tabOperator.Name = "tabOperator";
            this.tabOperator.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperator.Size = new System.Drawing.Size(645, 256);
            this.tabOperator.TabIndex = 0;
            this.tabOperator.Text = "Operator/Brand";
            this.tabOperator.UseVisualStyleBackColor = true;
            // 
            // tabGameProvider
            // 
            this.tabGameProvider.Location = new System.Drawing.Point(4, 25);
            this.tabGameProvider.Name = "tabGameProvider";
            this.tabGameProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameProvider.Size = new System.Drawing.Size(645, 256);
            this.tabGameProvider.TabIndex = 1;
            this.tabGameProvider.Text = "Game Provider";
            this.tabGameProvider.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptAuthTokenToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // decryptAuthTokenToolStripMenuItem
            // 
            this.decryptAuthTokenToolStripMenuItem.Name = "decryptAuthTokenToolStripMenuItem";
            this.decryptAuthTokenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.decryptAuthTokenToolStripMenuItem.Text = "Decrypt Auth Token";
            this.decryptAuthTokenToolStripMenuItem.Click += new System.EventHandler(this.decryptAuthTokenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboServerBaseUrl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UGS API Tester";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOperator.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorizePlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServerBaseUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOperator;
        private System.Windows.Forms.TabPage tabGameProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptAuthTokenToolStripMenuItem;
    }
}

