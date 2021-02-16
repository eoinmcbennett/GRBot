using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;


namespace GRBot.Commands
{
    public class PingModule : BaseCommandModule
    {
        [Command("ping")]
        public async Task PingCommand(CommandContext ctx)
        {
            Console.WriteLine("Received ping command from " + ctx.Member.Nickname + "!");
            await ctx.RespondAsync("pong!");
        }
    }
}