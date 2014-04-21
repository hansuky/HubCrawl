using HubCrawl.Models;
using HubCrawl.Models.Apps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Providers
{
    public static class HubCrawlInitializer
    {
        public static void Initialize()
        {
            ModuleProvider moduleProvider = new ModuleProvider();
            moduleProvider.Initialize();
            PlugInProvider plugInProvider = new PlugInProvider();
            plugInProvider.Initialize();
            AddonProvider addonProvier = new AddonProvider();
            addonProvier.Initialize();
            AppProvider appProvider = new AppProvider();
            appProvider.Initialize();
        }
    }
}
