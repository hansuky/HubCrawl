using HubCrawl.Core;
using HubCrawl.Core.Addons;
using HubCrawl.Models.Apps;
using HubCrawl.Models.Modules;
using HubCrawl.Core.PlugIns;
using HubCrawl.Core.Providers;
using HubCrawl.Events;
using HubCrawl.Models;
using System;
using System.Linq;
using System.Collections.ObjectModel;

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
            ObservableCollection<HubCrawlApp>
                apps = new ObservableCollection<HubCrawlApp>();
            foreach (var app in AppProvider.Apps)
                apps.Add(new HubCrawlApp(app));
            this.Apps = apps;

            ObservableCollection<HubCrawlModule>
                modules = new ObservableCollection<HubCrawlModule>();
            foreach (var module in ModuleProvider.Modules)
            {
                modules.Add(new HubCrawlModule(module));
            }
            this.Modules = modules;

            this.PlugIns = PlugInProvider.PlugIns;
            this.Addons = AddonProvider.Addons;
        }

        #region Modules

        private HubCrawlModule _CurrentModule;

        public HubCrawlModule CurrentModule
        {
            get { return _CurrentModule; }
            set
            {
                if (ChangedPropertyChanged<HubCrawlModule>("CurrentModule", ref _CurrentModule, ref value))
                {
                    if (_CurrentModule != null) { OnModuleSelected(_CurrentModule); }
                }
            }
        }

        protected void OnModuleSelected(HubCrawlCluster cluster)
        {
            if (ModuleSelected != null)
                ModuleSelected(this, cluster);
        }
        public event HubCrawlClusterEventHander ModuleSelected;

        private ObservableCollection<HubCrawlModule> _Modules;

        public ObservableCollection<HubCrawlModule> Modules
        {
            get { return _Modules; }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlModule>>("Modules", ref _Modules, ref value); }
        }

        #endregion

        #region PlugIns

        private ObservableCollection<HubCrawlPlugIn> _PlugIns;

        public ObservableCollection<HubCrawlPlugIn> PlugIns
        {
            get
            {
                if (_PlugIns == null) _PlugIns = new ObservableCollection<HubCrawlPlugIn>();
                return _PlugIns;
            }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlPlugIn>>("PlugIns", ref _PlugIns, ref value); }
        }


        #endregion 

        #region AddOns

        private ObservableCollection<HubCrawlAddon> _Addons;

        public ObservableCollection<HubCrawlAddon> Addons
        {
            get
            {
                if (_Addons == null) _Addons = new ObservableCollection<HubCrawlAddon>();
                return _Addons;
            }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlAddon>>("Addons", ref _Addons, ref value); }
        }


        #endregion

        #region Apps

        private ObservableCollection<HubCrawlApp> _ExcutedApps;

        public ObservableCollection<HubCrawlApp> ExcutedApps
        {
            get { return _ExcutedApps; }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlApp>>("ExcutedApps", ref _ExcutedApps, ref value); }
        }

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
