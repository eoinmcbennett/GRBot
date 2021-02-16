using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace GRBot.Commands
{
    /**
     * This modules handles all yellow card logic
     */
    public class YellowCardModule : BaseCommandModule
    {
        [Command("giveyellowcard"),Description("Gives the mentioned user a yellow card.")]
        public async Task GiveYellowCardCommand(CommandContext ctx, string user, string reason)
        {
            //Do database lookup for existing card
            //If they have one return
            //If they dont have one issue one
            //Set yellow card role
            //Done!
        }

        [Command("showcards"), Description("Shows all currently active yellow cards.")]
        public async Task ShowCurrentCardsCommand(CommandContext ctx)
        {
            //Do database lookup for the current cards
            //Create message embed with them
            //SEND IT
        }
    }
}