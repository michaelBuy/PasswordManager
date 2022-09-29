using PasswordManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PasswordManager.Helper
{
    public static class DatabaseHelper
    {
        public static void SaveDatabase(string path, Database database)
        {
            var fileName = Guid.NewGuid().ToString() + ".tmp";
            var tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

            File.WriteAllText(tempFilePath, JsonSerializer.Serialize(database));

            Security.EncryptFile(database.Hash, tempFilePath, path); 

            File.Delete(tempFilePath);
        }
    }
}
