using System;
using System.Reflection;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using GRBot.Configuration;
using Microsoft.Extensions.Logging;

namespace GRBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            Console.WriteLine("Reading configs");
            //Get configs at default path
            Config config;

            try
            {
                config = new Config();
            }
            catch (ConfigException ce)
            {
                Console.WriteLine("Failed to load configs! " + ce.Message);
                return;
            }

            new Bot(config);
        }

        
    }
}