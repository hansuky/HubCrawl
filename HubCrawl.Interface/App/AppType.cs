using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Interface.App
{
    /// <summary>
    /// HubCrawl Supports Application Types
    /// </summary>
    public enum AppType
    {
        [Description("Console Application")]
        Console,
        [Description("WPF Windows Application")]
        WPF,
        [Description("WPF Page Application")]
        Page,
        [Description("Winform Application")]
        Winform,
        [Description("Web Brower")]
        Browser
    }
}
