using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Models
{
    public class MetroMenu
    {
        private ObservableCollection<MetroMenuItem> _menu;

        public ObservableCollection<MetroMenuItem> Menu
        {
            get { return _menu; }
        }
        public MetroMenu()
        {
            _menu = new ObservableCollection<MetroMenuItem>();
            _generate();
        }

        private void _generate()
        {
            _menu.Add(new MetroMenuItem("Office365", MetroMenuResources.Logo.Office));
            _menu.Add(new MetroMenuItem("Recipient", MetroMenuResources.Logo.User));
            _menu.Add(new MetroMenuItem("Provisioning", MetroMenuResources.Logo.Provision));
            _menu.Add(new MetroMenuItem("Migration", MetroMenuResources.Logo.Migration));
            _menu.Add(new MetroMenuItem("Permissions", MetroMenuResources.Logo.Permission));
            _menu.Add(new MetroMenuItem("Compliance", MetroMenuResources.Logo.Compliance));
            _menu.Add(new MetroMenuItem("Reporting", MetroMenuResources.Logo.Reports));
            _menu.Add(new MetroMenuItem("Domains", MetroMenuResources.Logo.Domain));
            _menu.Add(new MetroMenuItem("Mailbox Settings", MetroMenuResources.Logo.Settings));
            _menu.Add(new MetroMenuItem("Impersonation", MetroMenuResources.Logo.Impersonation));
            _menu.Add(new MetroMenuItem("Mailbox Options", MetroMenuResources.Logo.MailboxOptions));
            _menu.Add(new MetroMenuItem("Exchange ActiveSync", MetroMenuResources.Logo.ActiveSync));
            _menu.Add(new MetroMenuItem("Unified Messaging", MetroMenuResources.Logo.Messaging));
            _menu.Add(new MetroMenuItem("About", MetroMenuResources.Logo.About));
        }

    }
}
