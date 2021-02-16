using System;

namespace GRBot.Configuration
{
    public class ConfigFileReader
    {
        private const string DEFAULT_CONFIG_PATH = "config.txt";

        private string _path;
        
        public ConfigFileReader()
        {
            this._path = DEFAULT_CONFIG_PATH;
        }

        public ConfigFileReader(string path)
        {
            this._path = path;
        }

        public ConfigField[] getConfigs()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(this._path);

                if (lines.Length == 0)
                {
                    return null;
                }

                ConfigField[] configs = new ConfigField[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(":");
                    configs[i] = new ConfigField(parts[0], parts[1]);
                }

                return configs;
            }
            catch(Exception e)
            {
                throw new ConfigException(e.Message);
            }
        }
    }
}