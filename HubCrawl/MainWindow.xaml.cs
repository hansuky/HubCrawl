using HubCrawl.Core;
using HubCrawl.Interface.App;
using HubCrawl.Models.Modules;
using HubCrawl.Views;
using HubCrawl.Views.Apps;
using HubCrawl.WPF;
using MahApps.Metro.Controls;
using System;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Forms.Integration;

namespace HubCrawl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private HubCrawlView _MainView;
        /// <summary>
        /// HubCrawl Main View
        /// </summary>
        public HubCrawlView MainView
        {
            get
            {
                if (_MainView == null)
                {
                    _MainView = new HubCrawlView();
                    _MainView.ViewModel.ModuleSelected += ViewModel_ModuleSelected;
                }
                return _MainView;
            }
        }

        void ViewModel_ModuleSelected(object sender, HubCrawlCluster cluster)
        {
            ExecuteModule(cluster as HubCrawlModule);
        }

        public MainWindow()
        {
            InitializeComponent();
            SetView(MainView);
            
            //var logInView = new HubCrawl.Views.Account.LogInView();
            //logInView.Skip += logInView_Skip;
            //SetView(logInView);
        }

        void logInView_Skip(object sender, EventArgs e)
        {
            var initView = new HubCrawl.Views.InitializationView();
            initView.HubCrawlInitialized += initView_HubCrawlInitialized;
            SetView(initView);
        }

        void initView_HubCrawlInitialized(object sender, EventArgs e)
        {
            SetView(new HubCrawl.Views.HubCrawlView());
        }

        public void SetMainView()
        {
            SetView(MainView);
        }

        public void SetView(Object view)
        {
            this.LayoutRoot.Content = view;
            this.LayoutRoot.ReloadTransition();
        }

        public void SetModuleView(Object view)
        {
            this.MainView.ModuleLayoutRoot.Content = view;
            this.MainView.ModuleLayoutRoot.ReloadTransition();
        }

        #region Execution Methods

        public void ExecuteModule(HubCrawlModule module)
        {
            String directory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            String loadDllPath = String.Format(@"{0}\{1}", directory, module.FilePath);
            Assembly ass = Assembly.LoadFile(loadDllPath);
            foreach (Type t in ass.GetExportedTypes())
            {
                if (t.BaseType == typeof(ModuleCluster))
                {
                    ModuleCluster cluster = (ModuleCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    SetModuleView(cluster.Module);
                }
            }
        }

        public void ExecuteApp(HubCrawl.Models.Apps.HubCrawlApp app)
        {
            String directory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            String loadDllPath = String.Format(@"{0}\{1}", directory, app.FilePath);
            Assembly ass = Assembly.LoadFile(loadDllPath);
            foreach (Type t in ass.GetExportedTypes())
            {
                if (t.BaseType == typeof(HubCrawl.WPF.AppCluster))
                {
                    HubCrawl.WPF.AppCluster cluster = (HubCrawl.WPF.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    ExecuteApp(cluster);
                    break;
                }
                else if (t.BaseType == typeof(HubCrawl.Winform.AppCluster))
                {
                    HubCrawl.Winform.AppCluster cluster = (HubCrawl.Winform.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    ExecuteApp(cluster, AppType.Winform);
                    break;
                }
                else if (t.BaseType == typeof(HubCrawl.Browser.AppCluster))
                {
                    HubCrawl.Browser.AppCluster cluster = (HubCrawl.Browser.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    ExecuteApp(cluster, AppType.Browser);
                    break;
                }
            }
        }

        #endregion

        private void ShowSplash<T>(IAppCluster<T> cluster)
        {
            AppSplash splash = new AppSplash();
        }

        protected void ExecuteApp<T>(IAppCluster<T> cluster, AppType appType = AppType.WPF)
        {
            if (appType == AppType.WPF)
            {
                SetView(cluster.App);
            }
            else if (appType == AppType.Winform)
            {
                WindowsFormsHost formHost = new WindowsFormsHost();
                formHost.Child = cluster.App as System.Windows.Forms.Control;
                this.LayoutRoot.Content = formHost;
            }
            else if (appType == AppType.Browser)
            {
                WebBrowser browser = new WebBrowser();
                browser.Navigate(cluster.App.ToString());
                this.LayoutRoot.Content = browser;
            }
        }
    }
}
