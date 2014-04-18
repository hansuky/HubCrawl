using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Helpers
{
    public static class NavigationService
    {
        public static void Navigate(Object obj)
        {
            var mainWindow = App.Current.MainWindow as MainWindow;
            mainWindow.SetView(obj);
        }
    }
}
