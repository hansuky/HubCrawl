using HubCrawl.Module.Apps.Resources.Template.Selector;
using HubCrawl.WPF.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HubCrawl.Module.Apps
{
    public class AppPanoramaGroup : PanoramaGroup
    {
        public AppPanoramaGroup(string header, ICollectionView tiles)
            : base(header, tiles)
        {
            PanoramaItemSelector = new AppTileDataTemplateSelector();
        }

        private DataTemplateSelector _PanoramaItemSelector;
        public DataTemplateSelector PanoramaItemSelector
        {
            get
            {
                if (_PanoramaItemSelector == null) _PanoramaItemSelector = new AppTileDataTemplateSelector();
                return _PanoramaItemSelector;
            }
            private set { _PanoramaItemSelector = value; }
        }
    }
}
