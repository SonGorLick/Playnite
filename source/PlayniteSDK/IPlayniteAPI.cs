﻿using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK
{
    public interface IPlayniteAPI
    {
        IMainViewAPI MainView
        {
            get;
        }

        IGameDataseAPI Database
        {
            get;
        }

        IDialogsFactory Dialogs
        {
            get;
        }

        string ResolveGameVariables(Game game, string toResolve);        
    }
}
