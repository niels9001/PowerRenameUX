using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerRename
{
    public class ExplorerItem
    {
        public ExplorerItemType Type { get; set; }
        public string Original { get; set; }
        public string Renamed { get; set; }

    }

    public enum ExplorerItemType
    {
        Folder = 0,
        File = 1
    }
}
