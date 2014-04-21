using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Models
{
    [Serializable]
    public abstract class HubCrawlCluster : NotifyPropertyChangedBase
    {
        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { this.ChangedPropertyChanged<String>("Name", ref _Name, ref value); }
        }

        private String _ClusterDLLName;

        public String ClusterDLLName
        {
            get { return _ClusterDLLName; }
            set { ChangedPropertyChanged<String>("ClusterDLLName", ref _ClusterDLLName, ref value); }
        }

        public abstract String FilePath { get; }

        private String _Version;

        public String Version
        {
            get
            {
                if (String.IsNullOrEmpty(_Version))
                {
                    Assembly assembly = Assembly.LoadFrom(FilePath);
                    Version ver = assembly.GetName().Version;
                }
                return _Version;
            }
            set { ChangedPropertyChanged<String>("Version", ref _Version, ref value); }
        }


        public HubCrawlCluster() : base() { }
    }
}
