using HubCrawl.Core;
using HubCrawl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Events
{
    public class HubCrawlClusterEventArgs : EventArgs
    {
        private HubCrawlCluster _Cluster;

        public HubCrawlCluster Cluster
        {
            get { return _Cluster; }
            set { _Cluster = value; }
        }

        public HubCrawlClusterEventArgs() : base() { }
    }

    public delegate void HubCrawlClusterEventHander(Object sender, HubCrawlCluster cluster);
}
