using System;
using System.Configuration;

namespace ServiceManagerDemo.BO.Services
{
    public interface ISettingsService
    {
        Configuration GetConfiguration(Type type);
        KeyValueConfigurationElement ReadSetting(Type type, string key);
        void AddUpdateAppSettings(Type type, string key, string value);
        string GetTimeOut(Type type);
        void SetTimeOut(Type type, string value);
    }
}
