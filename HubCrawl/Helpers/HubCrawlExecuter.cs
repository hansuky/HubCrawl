using HubCrawl.Core.Executer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Helpers
{
    public class HubCrawlExecuter : IAppExecuter
    {
        private static HubCrawlExecuter Executer = new HubCrawlExecuter();

        public static HubCrawlExecuter Instance
        {
            get
            {
                if (Executer == null) Executer = new HubCrawlExecuter();
                return Executer;
            }
        }

        protected MainWindow Window
        {
            get
            {
                return App.Current.MainWindow as MainWindow;
            }
        }

        public void ExecuteApp(Core.Apps.HubCrawlApp app)
        {
            Window.ExecuteApp(app);
        }
    }
}
