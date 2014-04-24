using HubCrawl.Core;
using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Core.Modules
{
    [Serializable]
    public class HubCrawlModule : HubCrawlCluster
    {
        public override string FilePath
        {
            get
            {
                ModuleProvider provider = new ModuleProvider();
                return String.Format("{0}/{1}/{2}", provider.DirectoryPath, this.Name, this.ClusterDLLName);
            }
        }

        private String _ImagePathData;

        public String ImagePathData
        {
            get { return _ImagePathData; }
            set { ChangedPropertyChanged<String>("ImagePathData", ref _ImagePathData, ref value); }
        }


        private String _Title;

        public String Title
        {
            get { return _Title; }
            set { ChangedPropertyChanged<String>("Title", ref _Title, ref value); }
        }

        public HubCrawlModule() : base() { }

        public HubCrawlModule(HubCrawlModule module)
            : base(module)
        {
            this.Title = module.Title;
            this.ImagePathData = module.ImagePathData;
        }
    }
}
