using HubCrawl.Models.Addons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Providers
{
    public class AddonProvider : HubCrawlProvider<HubCrawlAddon>
    {
        private ObservableCollection<HubCrawlAddon> _Addons;
        public override ObservableCollection<HubCrawlAddon> Cluster
        {
            get
            {
                if (_Addons == null) _Addons = new ObservableCollection<HubCrawlAddon>();
                return _Addons;
            }
        }

        public override string DirectoryPath
        {
            get { return "Addons"; }
        }

        public override string FileName
        {
            get { return "Addons"; }
        }
    }
}
