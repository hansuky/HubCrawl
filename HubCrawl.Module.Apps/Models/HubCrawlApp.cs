using HubCrawl.Module.Apps.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Module.Apps.Models
{
    public class HubCrawlApp : HubCrawl.Core.Apps.HubCrawlApp, HubCrawl.WPF.Controls.IPanoramaTile
    {
        private System.Windows.Input.ICommand _TileClickedCommand;
        public System.Windows.Input.ICommand TileClickedCommand
        {
            get
            {
                if (_TileClickedCommand == null)
                    _TileClickedCommand = new HubCrawl.WPF.Controls.SimpleCommand<object, object>(ExecuteTileClickedCommand);
                return _TileClickedCommand;
            }
            private set { _TileClickedCommand = value; }
        }

        private Boolean _IsPressed;

        public Boolean IsPressed
        {
            get { return _IsPressed; }
            set { ChangedPropertyChanged<Boolean>("IsPressed", ref _IsPressed, ref value); }
        }

        public void ExecuteTileClickedCommand(object parameter)
        {
            OnExecuteApp(this);
        }

        public HubCrawlApp(HubCrawl.Core.Apps.HubCrawlApp app)
            : base(app) { }

        protected void OnExecuteApp(HubCrawlApp app)
        {
            if (ExecuteApp != null)
                ExecuteApp(this, new HubCrawlAppEventArgs(app));
        }
        public event HubCrawlAppEventHandler ExecuteApp;
    }
}
