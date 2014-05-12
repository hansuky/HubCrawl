using HubCrawl.Module.Apps.Models;
using HubCrawl.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HubCrawl.Module.Apps.Views
{
    /// <summary>
    /// AppPanorama.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AppPanorama : UserControl
    {
        public AppPanorama()
        {
            InitializeComponent();
            this.ViewModel.Load();
            this.ViewModel.Apps.CollectionChanged += Apps_CollectionChanged;
            SetPanoramaApps(this.ViewModel.Apps);
        }

        void Apps_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
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

        protected void SetPanoramaApps(ObservableCollection<HubCrawlApp> apps)
        {
            var appGroups = apps.GroupBy(a => a.Group);
            ObservableCollection<PanoramaGroup> appGroupCollection = new ObservableCollection<PanoramaGroup>();
            foreach (var group in appGroups)
            {
                appGroupCollection.Add(new AppPanoramaGroup(group.Key, CollectionViewSource.GetDefaultView(group)));
                PanoramaControl.SetBinding(HubCrawl.WPF.Controls.Panorama.ItemsSourceProperty, new Binding() { Source = appGroupCollection });
            }
        }
    }
}
