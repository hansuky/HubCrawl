using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.Common.Models;

namespace HubCrawl.Core.User
{
    public class HubCrawlUser : NotifyPropertyChangedBase
    {
        private String _UserID;
        /// <summary>
        /// HubCrawl User's Identity
        /// </summary>
        public String UserID
        {
            get { return _UserID; }
            set { ChangedPropertyChanged<String>("UserID", ref _UserID, ref value); }
        }


        public HubCrawlUser() : base() { }
    }
}
