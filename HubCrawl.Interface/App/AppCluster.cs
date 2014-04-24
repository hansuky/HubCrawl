using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Interface.App
{
    public abstract class AppCluster<T> : IAppCluster<T>
    {
        private AppType _AppType;
        public AppType AppType
        {
            get { return _AppType; }
            protected set { _AppType = value; }
        }

        private T _App;
        public virtual T App
        {
            get { return _App; }
            protected set { _App = value; }
        }

        public AppCluster(AppType type, T app)
        {
            this.AppType = type;
            this.App = app;
        }

        public void OnStartUp()
        {
            if (StartUp != null)
                StartUp(this, new EventArgs());
        }

        public event EventHandler StartUp;

        public void OnActivated()
        {
            if (Activated != null)
                Activated(this, new EventArgs());
        }

        public event EventHandler Activated;

        public void OnDeactivated()
        {
            if (Deactivated != null)
                Deactivated(this, new EventArgs());
        }

        public event EventHandler Deactivated;

        public virtual void AppCluster_StartUp(object sender, EventArgs e) { }
        public virtual void AppCluster_Activated(object sender, EventArgs e) { }
        public virtual void AppCluster_Deactivated(object sender, EventArgs e) { }

        protected void InitializeEvent()
        {
            this.StartUp += AppCluster_StartUp;
            this.Activated += AppCluster_Activated;
            this.Deactivated += AppCluster_Deactivated;
        }
    }
}
