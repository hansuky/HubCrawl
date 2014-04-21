using HubCrawl.Models.PlugIns;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Providers
{
    public class PlugInProvider : HubCrawlProvider<HubCrawlPlugIn>
    {
        private ObservableCollection<HubCrawlPlugIn> _PlugIns;
        public override ObservableCollection<HubCrawlPlugIn> Cluster
        {
            get
            {
                if (_PlugIns == null) _PlugIns = new ObservableCollection<HubCrawlPlugIn>();
                return _PlugIns;
            }
        }

        public override string DirectoryPath
        {
            get { return "PlugIns"; }
        }

        public override string FileName
        {
            get { return "PlugIns"; }
        }
    }
}
