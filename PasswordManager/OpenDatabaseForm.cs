using PasswordManager.Entity;
using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class OpenDatabaseForm : Form
    {
        private string? _DbFile;

        public string? DbFile
        {
            get => _DbFile;
            set => _DbFile = value;
        }
        public OpenDatabaseForm(string dbfile)
        {
            InitializeComponent();
            DbFile = dbfile;
            Text += $" - {Path.GetFileName(dbfile)}";
        }

        private void TogglePasswordChar(object sender, EventArgs e)
        {

        }

        private void Accept(object sender, EventArgs e)
        {
            var hash = Security.GetHash(tbxMasterPassword.Text);
            var file = Security.DecryptFile(hash, DbFile);

            if (!string.IsNullOrWhiteSpace(file))
            {
                var json = File.ReadAllText(file);
                File.Delete(file);

                ((MyPasswordManager)Owner).Database = JsonSerializer.Deserialize<Database>(json);
                ((MyPasswordManager)Owner).Database.Hash = hash;                
            }
            else
            {
                MessageBox.Show("Le mot de passe maître est invalide !", "MyPasswordManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxMasterPassword.Clear();
                DialogResult = DialogResult.None;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxMasterPassword.Select();
        }
    }
}
