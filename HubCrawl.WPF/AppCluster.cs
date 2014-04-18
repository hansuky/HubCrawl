using HubCrawl.Interface.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HubCrawl.WPF
{
    public class AppCluster : HubCrawl.Interface.App.AppCluster<ContentControl>
    {
        public AppCluster(ContentControl control) : base(AppType.WPF, control) { }
    }
}
