using System;
using System.Collections.Generic;
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

namespace HubCrawl.Views
{
    /// <summary>
    /// InitializationView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InitializationView : UserControl
    {
        public InitializationView()
        {
            InitializeComponent();
            this.Loaded += InitializationView_Loaded;
        }

        void InitializationView_Loaded(object sender, RoutedEventArgs e)
        {
            OnHubCrawlInitialized();
        }

        protected void OnHubCrawlInitialized()
        {
            if (HubCrawlInitialized != null) HubCrawlInitialized(this, null);
        }

        public event EventHandler HubCrawlInitialized;
    }
}
