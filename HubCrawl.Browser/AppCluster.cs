using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Browser
{
    public class AppCluster : HubCrawl.Interface.App.AppCluster<String>
    {
        public AppCluster(String url) : base(Interface.App.AppType.Browser, url) { }
    }
}
