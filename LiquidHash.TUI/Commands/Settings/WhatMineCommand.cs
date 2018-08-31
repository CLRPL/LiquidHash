using LiquidHash.TUI.Data;
using LiquidHash.UX.ViewModels;
using System;
using System.Linq;

namespace LiquidHash.TUI.Commands.Settings
{
    class WhatMineCommand
    {
        private readonly ApplicationViewModel app;
        private readonly Action<string> notificationHandler;

        public WhatMineCommand(
            ApplicationViewModel app,
            Action<string> notificationHandler)
        {
            this.app = app;
            this.notificationHandler = notificationHandler;
        }

        public bool HandleCommand(string[] input)
        {
            if (input.Count() == 3)
            {
                var arg1 = input[1];
                var arg2 = input[2];
                if (arg1.Equals(SettingArguments.ApiKey, StringComparison.OrdinalIgnoreCase))
                {
                    app.ApplicationConfiguration.WhatMineApiKey = arg2;
                    app.ApplicationConfiguration.SaveApplicationConfiguration();
                    notificationHandler(String.Format("WhatMine API key set: {0}", arg2));
                    return true;
                }
            }
            return false;
        }
    }
}
