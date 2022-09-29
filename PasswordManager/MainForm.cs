using PasswordManager.Entity;
using PasswordManager.Helper;
using System.ComponentModel;

namespace PasswordManager
{
    public partial class MyPasswordManager : Form
    {
        private const int DTG_PASSWORD_COLUMN_INDEX = 2;
        private const int NUMBER_OF_PASSWORD_CHAR = 8;
        public Database Database;

        private Configuration _Configuration;
        private Entry seletedEntry;

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

            Load += OnFormLoad;
            FormClosing += OnFormClosing;
            Shown += OnFormShown;

        }

        #region Form Events

        private void OnFormLoad(object? sender, EventArgs e)
        {
            Configuration = ConfigurationHelper.LoadConfiguration();

            if (!File.Exists(Configuration.LastUsedFile))
            {
                Configuration.LastUsedFile = null;
            }
        }
        private void OnFormShown(object? sender, EventArgs e)
        {
            if (Configuration.LastUsedFile is not null)
            {
                OpenDatabaseForm openDatabaseForm = new(Configuration.LastUsedFile);

                if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entries;
                    Text = $"MyPasswordManager - {Path.GetFileName(Configuration.LastUsedFile)}";
                }

            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(Configuration);

            if (Database != null)
                DatabaseHelper.SaveDatabase(Configuration.LastUsedFile, Database);
        }
        #endregion

        #region Entry Methods
        private void AddEntry(object sender, EventArgs e)
        {
            EntryForm entryForm = new EntryForm();

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entries.Add(entryForm.Entry);
                DatabaseHelper.SaveDatabase(Configuration.LastUsedFile, Database);
            }

        }

        private void EditEntry(object sender, EventArgs e)
        {
            if (DtgEntries.SelectedRows.Count == 1)
            {
                SetSelectedEntry();

                EntryForm entryForm = new(seletedEntry);
                seletedEntry.Password = Security.Decrypt(seletedEntry.Password, Database.Hash);

                if (entryForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.Refresh();
                    seletedEntry.Password = Security.Encrypt(seletedEntry.Password, Database.Hash);
                    DatabaseHelper.SaveDatabase(Configuration.LastUsedFile, Database);
                }
            }
        }

        private void SetSelectedEntry()
        {
            seletedEntry = (Entry)DtgEntries.CurrentRow.DataBoundItem;
        }

        private void DeleteEntry(object sender, EventArgs e)
        {
            SetSelectedEntry();

            var dialogResult = MessageBox.Show($"Êtes-vous certain de vouloir supprimer définitivement l'entrée sélectionnée ? \n\n  " +
                $"-  {seletedEntry.Title}", "MyPasswordManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                Database.Entries.Remove(seletedEntry);
        }

        #endregion       

        #region Database Methods

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

                    DatabaseHelper.SaveDatabase(dbFile, Database);

                    Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                }
            }
        }

        private void OpenDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenDatabaseForm(ofd.FileName);
            }
        }

        private void OpenDatabaseForm(string dbFile)
        {
            OpenDatabaseForm openDatabaseForm = new(dbFile);

            if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
            {
                DtgEntries.DataSource = Database.Entries;
                Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                Configuration.LastUsedFile = dbFile;
            }
        }

        private void SaveDatabase(object sender, EventArgs e)
        {
            DatabaseHelper.SaveDatabase(Configuration.LastUsedFile, Database);
        }

        private void LockDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            OpenDatabaseForm(Configuration.LastUsedFile);
        }

        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            Configuration.LastUsedFile = null;
        }

        #endregion

        #region Menu Events
        private void MenufileOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleFileMenu(isEnabled: true);
            else
                ToggleFileMenu(isEnabled: false);
        }

        private void MenuEntryOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleEntryMenu(isEnabled: true);
            else
                ToggleEntryMenu(isEnabled: false);
        }
        #endregion

        #region Methods
        private void ToggleFileMenu(bool isEnabled)
        {
            menuSaveDatabase.Enabled = isEnabled;
            menuCloseDatabase.Enabled = isEnabled;
            menuLockDatabase.Enabled = isEnabled;
        }

        private void ToggleEntryMenu(bool isEnabled)
        {
            menuAddEntry.Enabled = isEnabled;
            menuCopyUsername.Enabled = isEnabled;
            menuCopyPassword.Enabled = isEnabled;

        }

        private void ToggleContextMenuNotify(bool isEnabled)
        {
            contextMenuLockDatabase.Enabled = isEnabled;
            contextMenuExit.Enabled = isEnabled;
        }

        #endregion

        #region Copy Methods
        private void CopyUsername(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (seletedEntry != null)
                Clipboard.SetText(seletedEntry.Username);
        }

        private void CopyPassword(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (seletedEntry != null) Clipboard.SetText(Security.Decrypt(seletedEntry.Password, Database.Hash));

        }
        #endregion

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgEntries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DTG_PASSWORD_COLUMN_INDEX)
                e.Value = new string('*', NUMBER_OF_PASSWORD_CHAR);
        }



        private void contextMenuNotifyOpening(object sender, CancelEventArgs e)
        {
            if (Database.Hash is not null)
                ToggleContextMenuNotify(isEnabled: true);
            else
                ToggleContextMenuNotify(isEnabled: false);

        }


    }
}