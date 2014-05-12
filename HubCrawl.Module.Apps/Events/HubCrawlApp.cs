using HubCrawl.Module.Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Module.Apps.Events
{
    public class HubCrawlAppEventArgs : EventArgs
    {
        public HubCrawlApp App { get; set; }

        public HubCrawlAppEventArgs(HubCrawlApp app = null)
        {
            this.App = app;
        }
    }

    public delegate void HubCrawlAppEventHandler(Object sender, HubCrawlAppEventArgs e);
}
