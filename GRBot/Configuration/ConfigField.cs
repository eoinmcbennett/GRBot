namespace GRBot.Configuration
{
    /**
     * Represents a config field
     */
    public class ConfigField
    {
        private readonly string _name;
        private readonly string _field;

        public ConfigField(string name, string field)
        {
            this._name = name;
            this._field = field;
        }

        public string getName()
        {
            return this._name;
        }

        public string getField()
        {
            return this._field;
        }
    }
}