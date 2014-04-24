using HubCrawl.Models.Apps;
using HubCrawl.Resources.Template.Selector;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HubCrawl.Controls
{
    /// <summary>
    /// AppPanorama.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AppPanorama : UserControl
    {
        public ObservableCollection<HubCrawlApp> ItemsSource
        {
            get { return (ObservableCollection<HubCrawlApp>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource",
            typeof(ObservableCollection<HubCrawlApp>), typeof(AppPanorama),
            new PropertyMetadata(new ObservableCollection<HubCrawlApp>(), OnItemsSourceChanged));

        protected static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var appPanorama = (d as AppPanorama);
            var apps = (ObservableCollection<HubCrawlApp>)e.NewValue;
            if (apps != null) apps.CollectionChanged += apps_CollectionChanged;
            var oldApps = (ObservableCollection<HubCrawlApp>)e.OldValue;
            if(oldApps != null) oldApps.CollectionChanged -= apps_CollectionChanged;
            var appGroups = apps.GroupBy(a => a.Group);
            ObservableCollection<PanoramaGroup> appGroupCollection = new ObservableCollection<PanoramaGroup>();
            foreach (var group in appGroups)
            {
                appGroupCollection.Add(new AppPanoramaGroup(group.Key, CollectionViewSource.GetDefaultView(group)));
            }
            appPanorama.Panorama.SetBinding(Panorama.ItemsSourceProperty, new Binding() { Source = appGroupCollection });
        }

        public DataTemplateSelector ItemTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty); }
            set { SetValue(ItemTemplateSelectorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemTemplateSelector.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTemplateSelectorProperty =
            DependencyProperty.Register("ItemTemplateSelector",
            typeof(DataTemplateSelector), typeof(AppPanorama),
            new PropertyMetadata(new AppTileDataTemplateSelector(), OnItemTemplateSelectorChanged));

        protected static void OnItemTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as AppPanorama).Panorama.PanoramaItemSelector = e.NewValue as DataTemplateSelector;
        }

        static void apps_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
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

        public AppPanorama()
        {
            InitializeComponent();
        }
    }
}
