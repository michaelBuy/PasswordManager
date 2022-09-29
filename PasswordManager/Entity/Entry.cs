using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Entry : ICloneable
    {
        private string _Uuid;
        [Browsable(false)]
        public string UUID
        {
            get => _Uuid; 
            set => _Uuid = value;
        }

        private string _Title;

        [DisplayName("Titre")]
        public string Title
        {
            get => _Title;
            set => _Title = value;
        }

        private string _Username;
        [DisplayName("Nom d'utilisateur")]
        public string Username
        {
            get => _Username;
            set => _Username = value;
        }

        private string _Password;

        [DisplayName("Mot de passe")]
        public string Password
        {
            get => _Password;
            set => _Password = value;
        }

        private string _Link;

        [DisplayName("Adresse (URL)")]
        public string Link
        {
            get => _Link;
            set => _Link = value;
        }

        private DateTime _CreateDate;

        [DisplayName("Date de création")]
        public DateTime CreateDate
        {
            get => _CreateDate;
            set => _CreateDate = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
