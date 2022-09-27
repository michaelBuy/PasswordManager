

using PasswordManager.Entity;
using PasswordManager.Helper;
using System.ComponentModel;

namespace PasswordManager
{
    public partial class MyPasswordManager : Form
    {
        public Database Database;

        private Configuration _Configuration;

        public Configuration Configuration
        {
            get => _Configuration;
            set => _Configuration = value;
        }
        public MyPasswordManager()
        {
            InitializeComponent();
            Database = new Database();
            Configuration = new Configuration();
        }
       

        private void NewDatabase(object sender, EventArgs e)
        {
           SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Base de données.mpm";
            sfd.Filter = "Fichier MPM de myPasswordManager | *.mpm";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new NewDatabaseForm();

                if (newDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.Entries = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.Entries;
                    Configuration.LastUsedFile = dbFile;

                    DatabaseHelper.SaveDatabase(Database);

                    Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                }
            }
        }
    }
}