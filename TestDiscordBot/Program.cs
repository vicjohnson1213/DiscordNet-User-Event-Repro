using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace TestDiscordBot
{
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            var client = new DiscordSocketClient();

            client.Log += Log;
            client.UserJoined += OnUserJoin;    // Doesn't work
            client.UserUpdated += OnUserUpdate;    // Doesn't work
            client.ChannelCreated += OnChannelCreate;  // Works fine

            await client.LoginAsync(TokenType.Bot, "...");
            await client.StartAsync();

            await Task.Delay(-1);
        }
        
        public async Task OnUserJoin(SocketGuildUser user)
        {
            Console.WriteLine(user.ToString());
        }
        public async Task OnUserUpdate(SocketUser u1, SocketUser u2)
        {
            Console.WriteLine(u1.ToString());
            Console.WriteLine(u2.ToString());
        }

        public async Task OnChannelCreate(SocketChannel channel)
        {
            Console.WriteLine(channel.ToString());
        }

        public Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
