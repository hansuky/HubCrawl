using HubCrawl.Models;
using HubCrawl.Models.Apps;
using HubCrawl.Providers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.Apps = AppProvider.Apps;
        }

        #region Apps

        private ObservableCollection<HubCrawlApp> _Apps;

        public ObservableCollection<HubCrawlApp> Apps
        {
            get
            {
                if (_Apps == null) _Apps = new ObservableCollection<HubCrawlApp>();
                return _Apps;
            }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlApp>>("Apps", ref _Apps, ref value); }
        }


        #endregion

        public HubCrawlViewModel() { Initialization(); }
    }
}
