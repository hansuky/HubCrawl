using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication
{
    public class WpfApplicationCluster : HubCrawl.WPF.AppCluster
    {
        public WpfApplicationCluster()
            :base(new MainControl())
        {
        }
    }
}
