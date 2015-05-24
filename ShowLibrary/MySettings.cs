using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowLibrary
{
    public class MySettings : ISettings
    {
        private readonly IDictionary<string, string> _settings = new Dictionary<string, string>();

        public MySettings(IDictionary<string, string> settings)
        {
            this._settings = settings;
        }

        public bool Contains(string name)
        {
            return _settings.ContainsKey(name);
        }

        public string GetValue(string name, string value)
        {
            string result;
            if (_settings.TryGetValue(name, out result))
                return result;
            else
                return value;
        }

        public void Remove(string name)
        {
            _settings.Remove(name);
        }

        public void SetValue(string name, string value)
        {
            _settings[name] = value;
        }
    }
}
