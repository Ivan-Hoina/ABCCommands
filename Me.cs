using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;

namespace MyPlugin
{
    public class Me : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "Me";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "me" };

        public List<string> Permissions => new List<string> {  };
        public UnturnedPlayer uplayer;
        public void Execute(IRocketPlayer caller, string[] command)
        {
            uplayer = (UnturnedPlayer)caller;
            if(command.Length > 0)
            {
                string message = uplayer.CharacterName + " ";
                foreach(string _message in command)
                {
                    message = message + _message;
                }
                ChatManager.sendChat(EChatMode.LOCAL, message);
            }
            else
            {
                ChatManager.say(uplayer.CSteamID, "Вы не ввели никаких параметров", UnityEngine.Color.red);
            }
        }
    }
}
