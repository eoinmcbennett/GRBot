using System;

namespace GRBot.Configuration
{
    public class ConfigException : Exception
    {
        public ConfigException(string message) : base(message)
        {
            
        }
    }
}