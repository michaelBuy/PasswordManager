namespace PasswordManager
{
    partial class NewDatabaseForm
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxRepeatMasterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMasterPassword = new System.Windows.Forms.TextBox();
            this.btnTogglePasswordChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(430, 153);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 34);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(309, 153);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(115, 34);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Ok";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.Accept);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.52798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Controls.Add(this.tbxRepeatMasterPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxMasterPassword, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTogglePasswordChar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbxRepeatMasterPassword
            // 
            this.tbxRepeatMasterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRepeatMasterPassword.Location = new System.Drawing.Point(220, 80);
            this.tbxRepeatMasterPassword.Name = "tbxRepeatMasterPassword";
            this.tbxRepeatMasterPassword.Size = new System.Drawing.Size(243, 31);
            this.tbxRepeatMasterPassword.TabIndex = 0;
            this.tbxRepeatMasterPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmation :";
            // 
            // tbxMasterPassword
            // 
            this.tbxMasterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMasterPassword.Location = new System.Drawing.Point(220, 16);
            this.tbxMasterPassword.Name = "tbxMasterPassword";
            this.tbxMasterPassword.Size = new System.Drawing.Size(243, 31);
            this.tbxMasterPassword.TabIndex = 1;
            this.tbxMasterPassword.UseSystemPasswordChar = true;
            this.tbxMasterPassword.TextChanged += new System.EventHandler(this.tbxMasterPassword_TextChanged);
            // 
            // btnTogglePasswordChar
            // 
            this.btnTogglePasswordChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTogglePasswordChar.Location = new System.Drawing.Point(469, 15);
            this.btnTogglePasswordChar.Name = "btnTogglePasswordChar";
            this.btnTogglePasswordChar.Size = new System.Drawing.Size(58, 34);
            this.btnTogglePasswordChar.TabIndex = 4;
            this.btnTogglePasswordChar.Text = "***";
            this.btnTogglePasswordChar.UseVisualStyleBackColor = true;
            this.btnTogglePasswordChar.Click += new System.EventHandler(this.TogglePasswordChar);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot de passe maître :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewDatabaseForm
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(554, 199);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un mot de passe maître";
            this.Load += new System.EventHandler(this.NewDatabaseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCancel;
        private Button BtnAccept;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbxRepeatMasterPassword;
        private Label label2;
        private TextBox tbxMasterPassword;
        private Label label1;
        private Button btnTogglePasswordChar;
    }
}