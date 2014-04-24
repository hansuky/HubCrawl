using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Core.Addons
{
    [Serializable]
    public class HubCrawlAddon : HubCrawlCluster
    {
        public override string FilePath
        {
            get
            {
                AddonProvider provider = new AddonProvider();
                return String.Format("{0}/{1}", provider.DirectoryPath, Name);
            }
        }

        public HubCrawlAddon() : base() { }
    }
}
