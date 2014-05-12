using HubCrawl.Module.Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HubCrawl.Module.Apps.Resources.Template.Selector
{
    public class AppTileDataTemplateSelector : DataTemplateSelector
    {
        public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;
            if (element != null && item != null && item is HubCrawlApp)
            {
                HubCrawlApp appItem = item as HubCrawlApp;
                switch (appItem.TileType)
                {
                    case HubCrawl.Core.Apps.HubCrawlAppTileType.Single:
                        return element.FindResource("SingleHubCrawlApp") as DataTemplate;
                    case HubCrawl.Core.Apps.HubCrawlAppTileType.Double:
                        return element.FindResource("DoubleHubCrawlApp") as DataTemplate;
                    case HubCrawl.Core.Apps.HubCrawlAppTileType.Quadruple:
                        return element.FindResource("QuadrupleHubCrawlApp") as DataTemplate;
                    default:
                        break;
                }
            }
            return base.SelectTemplate(item, container);
        }
    }
}
