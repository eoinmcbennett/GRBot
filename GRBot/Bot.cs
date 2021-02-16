using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using GRBot.Configuration;
using Microsoft.Extensions.Logging;

namespace GRBot
{
    public class Bot
    {
        private Config _config;


        public Bot(Config config)
        {
            if (config == null)
            {
                throw new ConfigException("Config object passed to bot was null!");
            }
            this._config = config;
            
            StartAsync().GetAwaiter().GetResult();
        }

        private async Task StartAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = this._config["Token"],
                TokenType = TokenType.Bot,
                MinimumLogLevel = LogLevel.Debug
            });
            
            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new [] { this._config["CommandPrefix"]}
            });
            
            commands.RegisterCommands(Assembly.GetExecutingAssembly());

            discord.MessageCreated += async (s, e) =>
            {
                Console.WriteLine("Received message!");
                Console.WriteLine("From: " + e.Author.Username);
                Console.WriteLine("Text: " + e.Message.Content);
            };
            
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}