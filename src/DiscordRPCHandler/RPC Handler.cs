using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace DiscordRPCHandler
{
    public static class InitRPC
    {
        public static DiscordRpcClient Client { get; private set; }
        public static void Setup()
        {
            Client = new DiscordRpcClient("861016966855786516");  //Creates the client
            Client.Initialize();                            //Connects the client

            //Set Presence
            Client.SetPresence(new RichPresence()
            {
                Details = "Creating Battle Teams!",
                State = "More than likely...",
                Assets = new Assets()
                {
                    LargeImageKey = "discord_rcp",
                    LargeImageText = "Creating Battle Teams!"
                }
            });

        }
        
    }
    public static class Disp
    {
        public static DiscordRpcClient Client { get; private set; }
        public static void Dispose()
        {
            Client = new DiscordRpcClient("861016966855786516");  //Creates the client
            Client.Initialize();                            //Connects the client

            Client.Dispose();
        }
    }
}
