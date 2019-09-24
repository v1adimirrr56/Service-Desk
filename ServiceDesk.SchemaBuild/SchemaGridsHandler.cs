using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SchemaBuild.Builders;
using ServiceDesk.SchemaBuild.Loaders;
using ServiceDesk.SmartUI.Grids;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaGridsHandler
    {
        private readonly IGridBuilder _gridBuilder;
        private readonly ModelLoader _modelLoader;

        public SchemaGridsHandler(
            IGridBuilder gridBuilder,
            ModelLoader modelLoader)
        {
            _gridBuilder = gridBuilder;
            _modelLoader = modelLoader;
        }

        public Grid Handle(string context, string schema)
        {
            var properties = _modelLoader.LoadModel<GridAttribute>(context, schema);
            var grid = _gridBuilder.BuildGrid(properties);

            return grid;
        }
    }
}
