using JetBrains.Annotations;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace MyPlugin
{
    public class Config : IRocketPluginConfiguration
    {
        public static UnturnedPlayer Uplayer;
        public List<Data> conf = new List<Data>();
        public uint ExpForCode;
        public void LoadDefaults()
        {
            ExpForCode = 500;
        }
        public class Data
        { 
            public string Name;          
        }
    }
}
