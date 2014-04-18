using HubCrawl.Helpers;
using HubCrawl.Interface.App;
using HubCrawl.WPF;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HubCrawl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //Assembly ass = Assembly.LoadFile(@"D:\Projects\GitHub\HubCrawl\WpfApplication\bin\Debug\WpfApplication.dll");
            //Assembly ass = Assembly.LoadFile(@"D:\Projects\GitHub\HubCrawl\WindowsFormsApplication\bin\Debug\WindowsFormsApplication.dll");
            Assembly ass = Assembly.LoadFile(@"D:\Projects\GitHub\HubCrawl\BrowserApplication\bin\Debug\BrowserApplication.dll");
            
            foreach (Type t in ass.GetExportedTypes())
            {
                //t.GetInterfaceMap(typeof(HubCrawl.WPF.AppCluster
                if (t.BaseType == typeof(HubCrawl.WPF.AppCluster))
                {
                    HubCrawl.WPF.AppCluster cluster = (HubCrawl.WPF.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    SetView(cluster.App);
                }
                else if (t.BaseType == typeof(HubCrawl.Winform.AppCluster))
                {
                    HubCrawl.Winform.AppCluster cluster = (HubCrawl.Winform.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    SetView(cluster.App, AppType.Winform);
                }
                else if (t.BaseType == typeof(HubCrawl.Browser.AppCluster))
                {
                    HubCrawl.Browser.AppCluster cluster = (HubCrawl.Browser.AppCluster)t.InvokeMember(null,
                        BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                    SetView(cluster.App, AppType.Browser);
                }
            }
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

        public void SetView(Object view, AppType appType = AppType.WPF)
        {
            if (appType == AppType.WPF)
            {
                this.LayoutRoot.Content = view;
                this.LayoutRoot.ReloadTransition();
            }
            else if (appType == AppType.Winform)
            {
                WindowsFormsHost formHost = new WindowsFormsHost();
                formHost.Child = view as System.Windows.Forms.Control;
                this.LayoutRoot.Content = formHost;
            }
            else if (appType == AppType.Browser)
            {
                WebBrowser browser = new WebBrowser();
                browser.Navigate(view.ToString());
                this.LayoutRoot.Content = browser;
            }
        }
    }
}
