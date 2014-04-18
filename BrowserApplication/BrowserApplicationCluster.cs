using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserApplication
{
    public class BrowserApplicationCluster : HubCrawl.Browser.AppCluster
    {
        public BrowserApplicationCluster() : base("http://naver.com") { }
    }
}
