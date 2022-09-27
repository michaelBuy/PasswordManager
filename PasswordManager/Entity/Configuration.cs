using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Configuration
    {
        private string _LastUsedFile;
        public string LastUsedFile
        {
            get => _LastUsedFile;
            set => _LastUsedFile = value;
        }
    }
}
