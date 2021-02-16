namespace GRBot.Configuration
{
    public class Config
    {
        private ConfigField[] configFields;


        public Config(string path)
        {
            configFields = new ConfigFileReader(path).getConfigs();
        }

        public Config()
        {
            configFields = new ConfigFileReader().getConfigs();
        }

        public ConfigField[] getConfigs()
        {
            return this.configFields;
        }


        //Getter for the configs
        public string this[string name]
        {
            get
            {
                for (int i = 0; i < this.configFields.Length; i++)
                {
                    if (this.configFields[i].getName().Equals(name))
                    {
                        return this.configFields[i].getField();
                    }
                }

                return null;
            }
        }
    }
}