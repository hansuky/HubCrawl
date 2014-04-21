using HubCrawl.Models.Apps;
using HubCrawl.Models.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Providers
{
    public class ModuleProvider : HubCrawlProvider<HubCrawlModule>
    {
        private static ObservableCollection<HubCrawlModule> _Modules;
        public override ObservableCollection<HubCrawlModule> Cluster
        {
            get
            {
                if (_Modules == null) _Modules = new ObservableCollection<HubCrawlModule>();
                return _Modules;
            }
        }

        public override string DirectoryPath
        {
            get { return "Modules"; }
        }

        public override string FileName
        {
            get { return "Modules"; }
        }
    }
}
