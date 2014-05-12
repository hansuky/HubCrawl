using HubCrawl.Core;
using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Core.PlugIns
{
    [Serializable]
    public class HubCrawlPlugIn : HubCrawlCluster
    {
        public override string FilePath
        {
            get
            {
                PlugInProvider provider = new PlugInProvider();
                return String.Format("{0}/{1}", provider.DirectoryPath, Name);
            }
        }

        public HubCrawlPlugIn() : base() { }
    }
}
