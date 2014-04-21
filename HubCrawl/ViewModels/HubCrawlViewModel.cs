using HubCrawl.Models;
using HubCrawl.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.ViewModels
{
    public class HubCrawlViewModel : Yuhan.WPF.ViewModels.ViewModelBase
    {
        private MetroMenu _AppList;

        public MetroMenu AppList
        {
            get
            {
                if (_AppList == null) _AppList = new MetroMenu();
                return _AppList;
            }
            set { ChangedPropertyChanged<MetroMenu>("AppList", ref _AppList, ref value); }
        }

        public void ExecuteAsync(Action action)
        {
            
        }

        public void Initialization()
        {
            HubCrawlInitializer.Initialize();
        }

        public HubCrawlViewModel() { Initialization(); }
    }
}
