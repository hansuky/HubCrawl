using HubCrawl.Core.PlugIns;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HubCrawl.Core.Providers
{
    public class PlugInProvider : HubCrawlProvider<HubCrawlPlugIn>
    {
        public static ObservableCollection<HubCrawlPlugIn> PlugIns { get; private set; }
        [XmlArray(ElementName = "HubCrawlPlugIns")]
        [XmlArrayItem(ElementName = "HubCrawlPlugIns")]
        public override ObservableCollection<HubCrawlPlugIn> Cluster
        {
            get
            {
                if (PlugIns == null) PlugIns = new ObservableCollection<HubCrawlPlugIn>();
                return PlugIns;
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
