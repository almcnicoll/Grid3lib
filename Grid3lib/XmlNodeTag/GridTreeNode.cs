using System;
using System.Collections.Generic;
using System.Text;
using TreeCollections;

namespace Grid3lib.XmlNodeTag
{
    public class GridDefinition<TValue> : NamedEntityDefinition<Guid, TValue>
        where TValue : Grid
    {
        public static readonly GridDefinition<TValue> Instance = new GridDefinition<TValue>();

        private GridDefinition() : base(c => c.GridId.GetValueOrDefault(), c => c.Name, StringComparer.OrdinalIgnoreCase)
        { }
    }


    /// <summary>
    /// Used for representing a Grid in a tree structure
    /// </summary>
    public class GridTreeNode : MutableEntityTreeNode<GridTreeNode, Guid, string, Grid>
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Grid grid { get; set; }

        public GridTreeNode(Grid item)
            : base(GridDefinition<Grid>.Instance, item, ErrorCheckOptions.All)
        { }

        private GridTreeNode(Grid item, GridTreeNode parent)
            : base(item, parent)
        { }

        protected override GridTreeNode Create(Grid value, GridTreeNode parent)
        {
            return new GridTreeNode(value, parent);
        }

        protected override void SetItemName(string name)
        {
            grid.Name = name;
        }
    }
}
