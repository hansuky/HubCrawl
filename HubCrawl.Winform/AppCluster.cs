using HubCrawl.Interface.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubCrawl.Winform
{
    public class AppCluster : HubCrawl.Interface.App.AppCluster<Control>
    {
        public AppCluster(Control control) : base(AppType.Winform, control) { }
    }
}
