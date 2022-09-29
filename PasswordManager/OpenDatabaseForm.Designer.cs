namespace PasswordManager
{
    partial class OpenDatabaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMasterPassword = new System.Windows.Forms.TextBox();
            this.btnTogglePasswordChar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mot de passe maître :";
            // 
            // tbxMasterPassword
            // 
            this.tbxMasterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMasterPassword.Location = new System.Drawing.Point(217, 34);
            this.tbxMasterPassword.Name = "tbxMasterPassword";
            this.tbxMasterPassword.Size = new System.Drawing.Size(267, 31);
            this.tbxMasterPassword.TabIndex = 4;
            this.tbxMasterPassword.UseSystemPasswordChar = true;
            //this.tbxMasterPassword.TextChanged += new System.EventHandler(this.tbxMasterPassword_TextChanged);
            // 
            // btnTogglePasswordChar
            // 
            this.btnTogglePasswordChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTogglePasswordChar.Location = new System.Drawing.Point(490, 34);
            this.btnTogglePasswordChar.Name = "btnTogglePasswordChar";
            this.btnTogglePasswordChar.Size = new System.Drawing.Size(58, 34);
            this.btnTogglePasswordChar.TabIndex = 5;
            this.btnTogglePasswordChar.Text = "***";
            this.btnTogglePasswordChar.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(436, 87);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 34);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(315, 87);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(115, 34);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "Ok";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.Accept);
            // 
            // OpenDatabaseForm
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(571, 139);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnTogglePasswordChar);
            this.Controls.Add(this.tbxMasterPassword);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(593, 195);
            this.MinimumSize = new System.Drawing.Size(593, 195);
            this.Name = "OpenDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OpenDatabaseForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbxMasterPassword;
        private Button btnTogglePasswordChar;
        private Button BtnCancel;
        private Button BtnAccept;
    }
}