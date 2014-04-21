using HubCrawl.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Models.Modules
{
    [Serializable]
    public class HubCrawlModule : HubCrawlCluster
    {
        public override string FilePath
        {
            get
            {
                ModuleProvider provider = new ModuleProvider();
                return String.Format("{0}/{1}", provider.DirectoryPath, Name);
            }
        }

        public HubCrawlModule() : base() { }
    }
}
