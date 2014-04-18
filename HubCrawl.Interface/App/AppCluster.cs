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

        
    }
}
