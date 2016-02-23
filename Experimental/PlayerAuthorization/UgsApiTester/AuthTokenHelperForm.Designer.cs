namespace UgsApiTester
{
    partial class AuthTokenHelperForm
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
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.btnDecryptToken = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecrypted.Location = new System.Drawing.Point(68, 172);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecrypted.Size = new System.Drawing.Size(628, 285);
            this.txtDecrypted.TabIndex = 31;
            // 
            // btnDecryptToken
            // 
            this.btnDecryptToken.Location = new System.Drawing.Point(68, 123);
            this.btnDecryptToken.Name = "btnDecryptToken";
            this.btnDecryptToken.Size = new System.Drawing.Size(291, 34);
            this.btnDecryptToken.TabIndex = 30;
            this.btnDecryptToken.Text = "&Decrypt token and copy to clipboard";
            this.btnDecryptToken.UseVisualStyleBackColor = true;
            this.btnDecryptToken.Click += new System.EventHandler(this.btnDecryptToken_Click);
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(68, 29);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(628, 76);
            this.txtToken.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "token";
            // 
            // AuthTokenHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 489);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnDecryptToken);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuthTokenHelperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthTokenHelperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Button btnDecryptToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label9;
    }
}