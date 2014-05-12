using HubCrawl.Core;
using HubCrawl.Core.Apps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Core.Providers
{
    public static class HubCrawlInitializer
    {
        public static void Initialize()
        {
            ModuleInitialize();
            PlugInitialize();
            AddonInitialize();
            AppInitialize();
        }

        public static void ModuleInitialize()
        {
            ModuleProvider moduleProvider = new ModuleProvider();
            moduleProvider.Initialize();
        }

        public static void PlugInitialize()
        {
            PlugInProvider plugInProvider = new PlugInProvider();
            plugInProvider.Initialize();
        }

        public static void AddonInitialize()
        {
            AddonProvider addonProvier = new AddonProvider();
            addonProvier.Initialize();
        }

        public static void AppInitialize()
        {
            AppProvider appProvider = new AppProvider();
            appProvider.Initialize();
        }
    }
}
