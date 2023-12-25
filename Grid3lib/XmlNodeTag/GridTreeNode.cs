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
        /// <summary>
        /// The id of the grid
        /// </summary>
        public new Guid Id { get; set; }

        /// <summary>
        /// A reference to the <see cref="Grid"/> item itself
        /// </summary>
        public Grid? GridItem { get; set; } = null;

        /// <summary>
        /// Creates a node from the specified <see cref="Grid"/>
        /// </summary>
        /// <param name="item"></param>
        public GridTreeNode(Grid item)
            : base(GridDefinition<Grid>.Instance, item, ErrorCheckOptions.All)
        { }

        /// <summary>
        /// Creates a node from the specified <see cref="Grid"/> under the specified parent node
        /// </summary>
        /// <param name="item">The Grid object</param>
        /// <param name="parent">The parent node</param>
        private GridTreeNode(Grid item, GridTreeNode parent)
            : base(item, parent)
        { }

        /// <summary>
        /// Creates a new node from the specified <see cref="Grid"/> under the specified parent node
        /// </summary>
        /// <param name="value">The Grid object</param>
        /// <param name="parent">The parent node</param>
        /// <returns></returns>
        protected override GridTreeNode Create(Grid value, GridTreeNode parent)
        {
            return new GridTreeNode(value, parent);
        }

        /// <summary>
        /// Sets the name of the specified item
        /// </summary>
        /// <param name="name">The new name</param>
        protected override void SetItemName(string name)
        {
            if (GridItem == null) { return; }
            GridItem.Name = name;
        }
    }
}
