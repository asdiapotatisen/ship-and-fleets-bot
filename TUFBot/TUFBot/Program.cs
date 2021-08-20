namespace TUFBot
{
    using System;
    using System.Threading.Tasks;
    using DSharpPlus;
    using DSharpPlus.Entities;
    using DSharpPlus.EventArgs;

    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        public static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "NzYyOTM4OTA4MzQ1NzYxNzky.X3wcOg.-y5tlx9FDH6C3DKkoWSDH2d3peM",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async (s, e) => await Sus(s, e);

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        public static async Task Sus(DiscordClient client, MessageCreateEventArgs e)
        {
            // steve
            if (e.Author.Id == 800121038460813332)
            {
                await e.Message.CreateReactionAsync(DiscordEmoji.FromGuildEmote(client, 845424557603291156));
                return;
            }

            if (e.Message.Content.ToLower().Contains("sus"))
            {
                await e.Message.CreateReactionAsync(DiscordEmoji.FromGuildEmote(client, 845427941906579526));
            }
        }
    }
}