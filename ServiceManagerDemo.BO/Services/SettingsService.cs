using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace ServiceManagerDemo.BO.Services
{
    public class SettingsService : ISettingsService
    {
        string CON_TIMEOUT_KEY = "ConnectionTimeout";

        public Configuration GetConfiguration(Type type)
        {
            var map = new ExeConfigurationFileMap();
            map.ExeConfigFilename = Path.Combine(Assembly.GetAssembly(type).Location, ".config");

            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            return config;
        }

        public KeyValueConfigurationElement ReadSetting(Type type, string key)
        {
            try
            {
                var configFile = GetConfiguration(type);
                return configFile.AppSettings.Settings[key];
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Erro na leitura de arquivo de configuração.");
            }
        }

        public void AddUpdateAppSettings(Type type, string key, string value)
        {
            var configFile = GetConfiguration(type);
            var settings = configFile.AppSettings.Settings;

            if (settings[key] is null)
                settings.Add(key, value);
            else
                settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public string GetTimeOut(Type type)
        {
            var timeOut = ReadSetting(type, CON_TIMEOUT_KEY);
            return string.IsNullOrEmpty(timeOut.Value) ? "0" : timeOut.Value;
        }

        public void SetTimeOut(Type type, string value)
        {
            AddUpdateAppSettings(type, CON_TIMEOUT_KEY, value);
        }
    }
}
