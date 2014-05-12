using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Interface.Module
{
    public abstract class ModuleCluster<T> : IModuleCluster<T>
        where T : new()
    {
        private T _Module;
        public virtual T Module
        {
            get
            {
                if (_Module == null) _Module = new T();
                return _Module;
            }
            set { _Module = value; }
        }
    }
}
