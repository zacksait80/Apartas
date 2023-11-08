namespace Apartes
{
    partial class Send_Code
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(92, 141);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(646, 70);
            this.txtemail.TabIndex = 0;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(312, 268);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(189, 57);
            this.btnEmail.TabIndex = 1;
            this.btnEmail.Text = "Send";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(168, 415);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(499, 68);
            this.txtCode.TabIndex = 2;
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(324, 539);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(189, 57);
            this.btnCode.TabIndex = 3;
            this.btnCode.Text = "Verify Code";
            this.btnCode.UseVisualStyleBackColor = true;
            // 
            // Send_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 751);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtemail);
            this.Name = "Send_Code";
            this.Text = "Send_Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCode;
    }
}