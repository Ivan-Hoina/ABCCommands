using Rocket.API;
using Rocket.Core.Plugins;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;
using Rocket.Unturned.Player;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Logger = Rocket.Core.Logging.Logger;
using Rocket.Unturned;
using System;
using Rocket.Core.Steam;
using Rocket.Unturned.Extensions;
using MoreLinq;
using System.Linq;
using Rocket.Core;
using System.ServiceModel.Configuration;
using MoreLinq.Extensions;
using Rocket.Unturned.Permissions;
using System.Collections;
using System.Web.UI.WebControls;
using Rocket.Unturned.Events;

namespace MyPlugin
{
    public class MyPlugin : RocketPlugin<Config>
    {
        public static MyPlugin Instance;
        protected override void Load()
        {
            base.Load();
            Instance = this;

        }
        protected override void Unload()
        {
            base.Unload();
            Instance = null;


        }

        public override TranslationList DefaultTranslations => new TranslationList
        {
            {"NoPerms", "DoorPlugin: You Don't Have Enough Permissions" },
            {"AExsists", "DoorPlugin: The Door Already Exists" },
            {"NoExists", "DoorPlugin: The Door Doesn't Exist" },
            {"NoDoor", "DoorPlugin: This Is Not A Door" },
            {"DoorAdded", "DoorPlugin: Door Added With These Perms : " },
            {"DoorRemoved", "DoorPlugin : Door Removed" },
            {"DoorEdited", "DoorPlugin : Door Edited" }

        };
    }
}