using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Database
    {
        private string _Hash;

        [JsonIgnore]
        public string Hash
        {
            get => _Hash;
            set => _Hash = value;
        }

        private BindingList<Entry> _Entries;
        public BindingList<Entry> Entries
        {
            get => _Entries;
            set => _Entries = value;
        }

        public Database()
        {
            _Entries = new BindingList<Entry>();
        }
    }

}
