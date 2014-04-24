using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Interface.Module
{
    interface IModuleCluster<T>
    {
        T Module { get; }
    }
}
