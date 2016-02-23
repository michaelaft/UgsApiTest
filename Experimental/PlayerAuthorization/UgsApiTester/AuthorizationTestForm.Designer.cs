namespace UgsApiTester
{
    partial class AuthorizationTestForm
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGetToken = new System.Windows.Forms.TabPage();
            this.btnGetOAuthToken = new System.Windows.Forms.Button();
            this.cboScope = new System.Windows.Forms.ComboBox();
            this.cboGrantType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.tabAuthorize = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayerToken = new System.Windows.Forms.TextBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabGetToken.SuspendLayout();
            this.tabAuthorize.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(31, 382);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(751, 152);
            this.txtResponse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Response";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGetToken);
            this.tabControl1.Controls.Add(this.tabAuthorize);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabControl1.Location = new System.Drawing.Point(31, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 298);
            this.tabControl1.TabIndex = 15;
            // 
            // tabGetToken
            // 
            this.tabGetToken.Controls.Add(this.btnGetOAuthToken);
            this.tabGetToken.Controls.Add(this.cboScope);
            this.tabGetToken.Controls.Add(this.cboGrantType);
            this.tabGetToken.Controls.Add(this.label5);
            this.tabGetToken.Controls.Add(this.label4);
            this.tabGetToken.Controls.Add(this.txtClientSecret);
            this.tabGetToken.Controls.Add(this.txtClientId);
            this.tabGetToken.Controls.Add(this.label3);
            this.tabGetToken.Controls.Add(this.label2);
            this.tabGetToken.Controls.Add(this.label1);
            this.tabGetToken.Controls.Add(this.cboClientName);
            this.tabGetToken.Location = new System.Drawing.Point(4, 25);
            this.tabGetToken.Name = "tabGetToken";
            this.tabGetToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetToken.Size = new System.Drawing.Size(766, 269);
            this.tabGetToken.TabIndex = 0;
            this.tabGetToken.Text = "Get Token";
            this.tabGetToken.UseVisualStyleBackColor = true;
            // 
            // btnGetOAuthToken
            // 
            this.btnGetOAuthToken.Location = new System.Drawing.Point(113, 218);
            this.btnGetOAuthToken.Name = "btnGetOAuthToken";
            this.btnGetOAuthToken.Size = new System.Drawing.Size(179, 34);
            this.btnGetOAuthToken.TabIndex = 25;
            this.btnGetOAuthToken.Text = "Get OAuth Token";
            this.btnGetOAuthToken.UseVisualStyleBackColor = true;
            this.btnGetOAuthToken.Click += new System.EventHandler(this.btnGetOAuthToken_Click);
            // 
            // cboScope
            // 
            this.cboScope.FormattingEnabled = true;
            this.cboScope.Location = new System.Drawing.Point(113, 177);
            this.cboScope.Margin = new System.Windows.Forms.Padding(4);
            this.cboScope.Name = "cboScope";
            this.cboScope.Size = new System.Drawing.Size(179, 24);
            this.cboScope.TabIndex = 24;
            this.cboScope.Text = "playerapi";
            // 
            // cboGrantType
            // 
            this.cboGrantType.FormattingEnabled = true;
            this.cboGrantType.Location = new System.Drawing.Point(113, 145);
            this.cboGrantType.Margin = new System.Windows.Forms.Padding(4);
            this.cboGrantType.Name = "cboGrantType";
            this.cboGrantType.Size = new System.Drawing.Size(179, 24);
            this.cboGrantType.TabIndex = 23;
            this.cboGrantType.Text = "client_credentials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "scope";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "grant_type";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(113, 85);
            this.txtClientSecret.Multiline = true;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(647, 47);
            this.txtClientSecret.TabIndex = 20;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(113, 54);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(140, 22);
            this.txtClientId.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "client_secret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "client_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Client Name";
            // 
            // cboClientName
            // 
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(113, 18);
            this.cboClientName.Margin = new System.Windows.Forms.Padding(4);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(179, 24);
            this.cboClientName.TabIndex = 15;
            this.cboClientName.SelectedIndexChanged += new System.EventHandler(this.cboClientName_SelectedIndexChanged);
            // 
            // tabAuthorize
            // 
            this.tabAuthorize.Controls.Add(this.label7);
            this.tabAuthorize.Controls.Add(this.txtPlayerToken);
            this.tabAuthorize.Controls.Add(this.txtAccessToken);
            this.tabAuthorize.Controls.Add(this.label8);
            this.tabAuthorize.Controls.Add(this.btnAuthorize);
            this.tabAuthorize.Location = new System.Drawing.Point(4, 25);
            this.tabAuthorize.Name = "tabAuthorize";
            this.tabAuthorize.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthorize.Size = new System.Drawing.Size(766, 269);
            this.tabAuthorize.TabIndex = 1;
            this.tabAuthorize.Text = "Authorize Player";
            this.tabAuthorize.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "player token";
            // 
            // txtPlayerToken
            // 
            this.txtPlayerToken.Location = new System.Drawing.Point(142, 127);
            this.txtPlayerToken.Name = "txtPlayerToken";
            this.txtPlayerToken.ReadOnly = true;
            this.txtPlayerToken.Size = new System.Drawing.Size(592, 22);
            this.txtPlayerToken.TabIndex = 29;
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(142, 17);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(592, 22);
            this.txtAccessToken.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "brand\'s auth token";
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Location = new System.Drawing.Point(142, 58);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(179, 34);
            this.btnAuthorize.TabIndex = 26;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 269);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AuthorizationTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResponse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationTestForm";
            this.Load += new System.EventHandler(this.AuthorizationTestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGetToken.ResumeLayout(false);
            this.tabGetToken.PerformLayout();
            this.tabAuthorize.ResumeLayout(false);
            this.tabAuthorize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGetToken;
        private System.Windows.Forms.Button btnGetOAuthToken;
        private System.Windows.Forms.ComboBox cboScope;
        private System.Windows.Forms.ComboBox cboGrantType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.TabPage tabAuthorize;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayerToken;
        private System.Windows.Forms.TabPage tabPage1;
    }
}