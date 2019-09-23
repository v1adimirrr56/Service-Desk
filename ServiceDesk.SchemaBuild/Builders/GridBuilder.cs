using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using ServiceDesk.SmartUI.Grids;

namespace ServiceDesk.SchemaBuild.Builders
{
    public class GridBuilder : IGridBuilder
    {
        public Grid BuildGrid(IEnumerable<PropertyInfo> properties)
        {
            var grid = new Grid();
            grid.Columns = new List<Column>();
            foreach (var property in properties)
            {
                grid.Columns.Add(new Column
                {
                    Key = char.ToLower(property.Name[0]) + property.Name.Substring(1),
                    Label = property.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property.Name,
                    NameColumn = property.Name
                });
            }

            return grid;
        }
    }
}
