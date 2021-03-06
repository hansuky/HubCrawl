﻿using HubCrawl.Core.Executer;
using HubCrawl.Module.Apps.Views;
using HubCrawl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HubCrawl.Module.Apps
{
    public class AppModuleCluster : ModuleCluster
    {
        public static IAppExecuter AppExecuter { get; set; }

        public AppModuleCluster()
            : base()
        {
            this.Module = new AppPanorama();
        }
    }
}
