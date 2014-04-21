using HubCrawl.Models.Apps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HubCrawl.Providers
{
    public class AppProvider : HubCrawlProvider<HubCrawlApp>
    {
        private static ObservableCollection<HubCrawlApp> _Apps;
        [XmlArray(ElementName = "HubCrawlApps")]
        [XmlArrayItem(ElementName = "HubCrawlApps")]
        public override ObservableCollection<HubCrawlApp> Cluster
        {
            get
            {
                if (_Apps == null) _Apps = new ObservableCollection<HubCrawlApp>();
                return _Apps;
            }
        }

        public override string DirectoryPath
        {
            get { return "Apps"; }
        }

        public override string FileName
        {
            get { return "Apps"; }
        }

        public AppProvider()
        {
            Cluster.Add(new HubCrawlApp()
            {
                Name = "WpfApplication",
                ClusterDLLName = "WpfApplication.dll"
            });
            Cluster.Add(new HubCrawlApp()
            {
                Name = "WindowsFormsApplication",
                ClusterDLLName = "WindowsFormsApplication.dll"
            });
        }
    }
}
