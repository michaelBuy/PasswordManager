using PasswordManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace PasswordManager.Helper
{
    public static class ConfigurationHelper
    {
        private static readonly string configDirPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyPasswordManager");

        private static readonly string configFileName = "MyPassword.config.json";
        private static readonly string configFilepath = Path.Combine(configDirPath, configFileName);

        public static void SaveConfiguration(Configuration Configuration)
        {
            var json = JsonSerializer.Serialize(Configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);
            }

            File.WriteAllText(configFilepath, json);
        }

        public static Configuration LoadConfiguration()
        {
            Configuration configuration = new Configuration();

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);
                SaveConfiguration(configuration);

                return configuration;
            }

            var json = File.ReadAllText(configFilepath);

            return JsonSerializer.Deserialize<Configuration>(json)!;

            
        }

    }
}
