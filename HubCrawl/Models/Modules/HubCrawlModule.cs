using HubCrawl.Core;
using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Yuhan.Common.Models;

namespace HubCrawl.Models.Modules
{
    [Serializable]
    public class HubCrawlModule : HubCrawl.Core.Modules.HubCrawlModule
    {
        public HubCrawlModule() : base() { }

        public HubCrawlModule(Core.Modules.HubCrawlModule module)
            : base(module) { }
    }
}
