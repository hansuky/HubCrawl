using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Data.Config
{
    public class Connector
    {
        public String ConfigFilePath = "/Config/";

        public Connector()
        {
            DirectoryInitialize();
        }

        protected void DirectoryInitialize()
        {
            DirectoryInfo directory = new DirectoryInfo(ConfigFilePath);
            if (!directory.Exists)
                directory.Create();
        }

        protected void ConfigFileInitialize()
        {

        }
    }
}
