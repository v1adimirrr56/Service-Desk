using ServiceDesk.SmartUI.Grids;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SchemaBuild.Builders
{
    public interface IGridBuilder
    {
        Grid BuildGrid(IEnumerable<PropertyInfo> propertyInfos);
    }
}
