using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Interface.App
{
    public interface IAppCluster<T>
    {
        AppType AppType { get; }
        T App { get; }

        void OnStartUp();
        event EventHandler StartUp;
        void OnActivated();
        event EventHandler Activated;
        void OnDeactivated();
        event EventHandler Deactivated;
    }
}
