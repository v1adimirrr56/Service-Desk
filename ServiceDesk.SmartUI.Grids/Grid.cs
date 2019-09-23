using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.Grids
{
    public class Grid
    {
        public ICollection<Column> Columns { get; set; }
    }

    public class Column
    {
        public string NameColumn;
        public string Key;
        public string Label;
    }
}
