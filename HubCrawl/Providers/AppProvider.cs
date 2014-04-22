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
        public static ObservableCollection<HubCrawlApp> Apps { get; private set; }
        [XmlArray(ElementName = "HubCrawlApps")]
        [XmlArrayItem(ElementName = "HubCrawlApps")]
        public override ObservableCollection<HubCrawlApp> Cluster
        {
            get
            {
                if (Apps == null) Apps = new ObservableCollection<HubCrawlApp>();
                return Apps;
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
            if (Cluster.Count == 0)
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
}
