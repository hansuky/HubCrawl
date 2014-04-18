using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    public class WinFormsApplicationCluster : HubCrawl.Winform.AppCluster
    {
        public WinFormsApplicationCluster() : base(new MainControl()) { }
    }
}
