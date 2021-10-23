using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;


namespace MyPlugin
{
    public class Try : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "Try";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "try" };

        public List<string> Permissions => new List<string> { };
        public UnturnedPlayer uplayer;
        public void Execute(IRocketPlayer caller, string[] command)
        {
            uplayer = (UnturnedPlayer)caller;
            if (command.Length > 0)
            {
                string message = uplayer.CharacterName + " ";
                foreach (string _message in command)
                {
                    message = message + ' ' + _message;
                }

                Random random = new Random();
                int rand = random.Next(0, 1);
                if(rand == 0)
                {
                    message += " Не удачно";                  
                }
                else
                {
                    message += " Удачно";
                }
                ChatManager.sendChat(EChatMode.LOCAL, message)
            }
            else
            {
                ChatManager.say(uplayer.CSteamID, "Вы не ввели никаких параметров", UnityEngine.Color.red);
            }
        }
    }
}
