using HubCrawl.Module.Apps;
using HubCrawl.Core.Executer;
using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubCrawl.Module.Apps.Models;

namespace HubCrawl.Module.Apps.ViewModels
{
    public class AppViewModel : Yuhan.WPF.ViewModels.ViewModelBase
    {
        public IAppExecuter AppExecuter
        {
            get
            {
                return AppModuleCluster.AppExecuter;
            }
        }

        protected void ExecuteApp(HubCrawlApp app)
        {
            if (AppExecuter != null)
                AppExecuter.ExecuteApp(app);
            else System.Windows.MessageBox.Show("Executer is Null");
        }


        #region Apps

        private ObservableCollection<HubCrawlApp> _Apps;

        public ObservableCollection<HubCrawlApp> Apps
        {
            get
            {
                if (_Apps == null)
                {
                    _Apps = new ObservableCollection<HubCrawlApp>();
                    _Apps.CollectionChanged += _Apps_CollectionChanged;
                }
                return _Apps;
            }
            set { ChangedPropertyChanged<ObservableCollection<HubCrawlApp>>("Apps", ref _Apps, ref value); }
        }

        void _Apps_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    foreach (var app in e.NewItems.OfType<HubCrawlApp>())
                    {
                        app.ExecuteApp += (obj, evt) =>
                        {
                            ExecuteApp(evt.App);
                        };
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }

        #endregion

        public AppViewModel()
        {
            HubCrawlInitializer.AppInitialize();
        }

        public void Load()
        {
            foreach (var app in AppProvider.Apps)
                this.Apps.Add(new HubCrawlApp(app));
        }
    }
}
