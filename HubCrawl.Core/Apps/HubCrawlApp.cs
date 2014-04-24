using HubCrawl.Core;
using HubCrawl.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Core.Apps
{
    [Serializable]
    public class HubCrawlApp : HubCrawlCluster
    {
        private const String DefaultIconPath = "";

        public override string FilePath
        {
            get
            {
                AppProvider provider = new AppProvider();
                return String.Format("{0}/{1}/{2}", provider.DirectoryPath, this.Name, this.ClusterDLLName);
            }
        }

        private String _IconPath;

        public String IconPath
        {
            get
            {
                if (String.IsNullOrEmpty(_IconPath))
                {
                    return DefaultIconPath;
                }
                return _IconPath;
            }
            set { ChangedPropertyChanged<String>("IconPath", ref _IconPath, ref value); }
        }

        private String _Group;
        /// <summary>
        /// Application Group Name
        /// </summary>
        public String Group
        {
            get { return _Group; }
            set { ChangedPropertyChanged<String>("Group", ref _Group, ref value); }
        }

        private String _Title;
        /// <summary>
        /// Application Title
        /// </summary>
        public String Title
        {
            get
            {
                if (String.IsNullOrEmpty(_Title)) _Title = Name;
                return _Title;
            }
            set { ChangedPropertyChanged<String>("Title", ref _Title, ref value); }
        }

        #region External Properties
        private HubCrawlAppTileType _TileType;

        public HubCrawlAppTileType TileType
        {
            get { return _TileType; }
            set { ChangedPropertyChanged<HubCrawlAppTileType>("TileType", ref _TileType, ref value); }
        }

        public Boolean IsDoubleWidth
        {
            get
            {
                if (TileType == HubCrawlAppTileType.Single)
                    return false;
                return true;
            }
        }

        #endregion

        public HubCrawlApp() : base() { }

        public HubCrawlApp(HubCrawlApp app)
            : base(app)
        {
            this.Group = app.Group;
            this.IconPath = app.IconPath;
            this.TileType = app.TileType;
            this.Title = app.Title;
            this.Version = app.Version;
        }
    }
}
