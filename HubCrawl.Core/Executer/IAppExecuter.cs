using HubCrawl.Core.Apps;
using System;
namespace HubCrawl.Core.Executer
{
    public interface IAppExecuter
    {
        void ExecuteApp(HubCrawlApp app);
    }
}
