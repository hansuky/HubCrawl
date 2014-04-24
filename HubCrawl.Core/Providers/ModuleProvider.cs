using HubCrawl.Core.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HubCrawl.Core.Providers
{
    public class ModuleProvider : HubCrawlProvider<HubCrawlModule>
    {
        public static ObservableCollection<HubCrawlModule> Modules { get; private set; }
        [XmlArray(ElementName = "HubCrawlModules")]
        [XmlArrayItem(ElementName = "HubCrawlModules")]
        public override ObservableCollection<HubCrawlModule> Cluster
        {
            get
            {
                if (Modules == null) Modules = new ObservableCollection<HubCrawlModule>();
                return Modules;
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

        public ModuleProvider()
        {
            if (Cluster.Count == 0)
            {
                Cluster.Add(new HubCrawlModule()
                {
                    Name = "Apps",
                    ClusterDLLName = "HubCrawl.Module.Apps.dll",
                    Title = "Apps",
                    ImagePathData = "M119.9996,0L187.33301,20.667028 187.33301,206.66699 119.33293,226.66699 0,182.00028 120.667,197.77798 120.667,36.444982 40.222468,55.555956 40.222468,165.33381 0,181.99999 0,46.000032z"
                });
            }
        }
    }
}
