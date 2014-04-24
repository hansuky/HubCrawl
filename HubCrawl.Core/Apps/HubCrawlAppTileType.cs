using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubCrawl.Core.Apps
{
    public enum HubCrawlAppTileType
    {
        [Description("Single Tile")]
        Single,
        [Description("Double Tile")]
        Double,
        [Description("Quadruple Tile")]
        Quadruple
    }
}
