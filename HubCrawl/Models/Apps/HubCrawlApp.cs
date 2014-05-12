using HubCrawl.Controls;
using HubCrawl.Core;
using HubCrawl.Core.Providers;
using HubCrawl.Models.Modules;
using HubCrawl.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yuhan.Common.Models;

namespace HubCrawl.Models.Apps
{
    [Serializable]
    public partial class HubCrawlApp : HubCrawl.Core.Apps.HubCrawlApp, IPanoramaTile
    {
        private System.Windows.Input.ICommand _TileClickedCommand;
        public System.Windows.Input.ICommand TileClickedCommand
        {
            get
            {
                if (_TileClickedCommand == null)
                    _TileClickedCommand = new Yuhan.WPF.Commands.RelayCommand(ExecuteApp);
                return _TileClickedCommand;
            }
        }

        public void ExecuteApp()
        {
            var window = (App.Current.MainWindow as MainWindow);
            window.ExecuteApp(this);
        }

        private bool _IsPressed;
        public bool IsPressed
        {
            get { return _IsPressed; }
            set { ChangedPropertyChanged<Boolean>("IsPressed", ref _IsPressed, ref value); }
        }

        public HubCrawlApp(HubCrawl.Core.Apps.HubCrawlApp app)
            : base(app)
        { }
    }
}
