using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object padlock = new object();

        public Dictionary<string, string> Settings { get; private set; }

        ConfigurationManager()
        {
            Settings = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                    return instance;
                }
            }
        }

        public void UpdateSetting(string key, string value)
        {
            if (Settings.ContainsKey(key))
            {
                Settings[key] = value;
            }
            else
            {
                Settings.Add(key, value);
            }
        }
    }
}
