using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlParsing;
using TreeCollections;
using System.Security.Cryptography;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Grid within a <see cref="Gridset"/>
    /// </summary>
    public class Grid : XmlNodeBasic
    {
        private Entry? __FileMapEntry = null;

        /// <summary>
        /// Returns the parent node as a strongly-typed GridSet rather than as an IXmlNode
        /// </summary>
        public GridSet? ParentGridSet
        {
            get
            {
                return (Parent as GridSet);
            }
            set
            {
                Parent = value;
            }
        }

        /// <summary>
        /// Gets / sets the <see cref="Grid"/>'s name
        /// </summary>
        public String? Name { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the grid
        /// </summary>
        public Guid? GridId
        {
            get
            {
                List<GridGuid> idNodes = ChildrenOfType<GridGuid>();
                if (idNodes.Count == 0)
                {
                    return null;
                }
                else
                {
                    return new Guid(idNodes[0].InnerXmlString);
                }
            }
            set
            {
                List<GridGuid> idNodes = ChildrenOfType<GridGuid>();
                GridGuid guidNode;
                if (idNodes.Count == 0)
                {
                    guidNode = new GridGuid();
                    this.Children.Add(guidNode);
                }
                else
                {
                    guidNode = idNodes[0];
                }
                guidNode.InnerXml = new List<RawXml> { new RawXml(value.ToString()) };
            }
        }

        /// <summary>
        /// Returns all cells in the <see cref="Grid"/>
        /// </summary>
        public List<Cell> Cells
        {
            get
            {
                return this.ChildrenOfType<Cell>();
            }
        }

        /// <summary>
        /// The relative path of the grid within the <see cref="GridSet"/>
        /// </summary>
        public string RelativePath { get; set; } = null;

        //public List<Command> StartupCommands { get; set; } = new List<Command>();
        //public List<ScanBlockAudioDescription> ScanBlockAudioDescriptions { get; set; } = new List<ScanBlockAudioDescription>();

        /// <summary>
        /// Returns the number of columns in the Grid
        /// </summary>
        public int ColumnCount
        {
            get
            {
                return ChildrenOfType<ColumnDefinition>(1).Count;
            }
        }

        /// <summary>
        /// Returns the number of rows in the Grid
        /// </summary>
        public int RowCount
        {
            get
            {
                return ChildrenOfType<RowDefinition>(1).Count;
            }
        }

        /// <summary>
        /// Returns a reference to the <see cref="Grid"/>'s <see cref="Entry"/> in the GridSet's <see cref="FileMap"/>
        /// </summary>
        public Entry? FileMapEntry
        {
            get
            {
                if (__FileMapEntry == null)
                {
                    GridSet? gs = this.ParentGridSet;
                    if (gs == null) { return null; }
                    if (gs.Map == null) { return null; }
                    List<Entry> entries = gs.Map.ChildrenOfType<Entry>(2);
                    Entry? entry = (from Entry e in entries.Cast<Entry>()
                                    where e.StaticFile == ""
                                    select e).FirstOrDefault();
                    if (entry == null) { return null; }
                    __FileMapEntry = entry;
                }
                return __FileMapEntry;
            }
        }

        /// <summary>
        /// Parameterless constructor needed if creating from XML
        /// </summary>
        public Grid()
        {

        }

        /// <summary>
        /// Constructor if creating programmatically
        /// </summary>
        public Grid(bool GenerateGuid = true)
        {
            if (GenerateGuid) { GridId = Guid.NewGuid(); }
        }

        /// <summary>
        /// Fills the XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml">The source XML</param>
        /// <param name="PopulateChildren">Whether to populate the child nodes also</param>
        public override void PopulateFromXml(string Xml, int PopulateToDepth = 0)
        {
            // Always call base method to populate basic properties
            base.PopulateFromXml(Xml, PopulateToDepth);


        }

        /// <summary>
        /// Adds a <see cref="Cell"/> to the <see cref="Grid"/>
        /// </summary>
        /// <returns>A reference to the created <see cref="Cell"/></returns>
        public Cell AddCell(int x, int y, int colSpan = 1, int rowSpan = 1, string? label = null)
        {
            // Pre-creation checks
            List<Cell> existingCells = Cells;
            if ((existingCells != null) && (existingCells.Count > 0))
            {
                foreach (Cell c in existingCells)
                {
                    if (c != null)
                    {
                        // Check for overlap
                        if (
                            c.Left < (x + colSpan - 1) // Existing cell starts to the left of new cell's right border
                            && c.Right > x // Existing cell's right border is to the right of new cell's left border
                            && c.Top < (y + rowSpan - 1) // Existing cell starts above new cell's bottom border
                            && c.Bottom > y // Existing cell's bottom border is below new cell's top border
                            )
                        {
                            throw new CellOverlapException("Cell overlaps an existing cell", c);
                        }
                    }
                }
            }

            // Create, populate, add to grid
            Cell cell = new Cell();
            cell.Column = x;
            cell.Row = y;
            cell.ColumnSpan = colSpan;
            cell.RowSpan = rowSpan;
            cell.Parent = this;
            if (label != null) { cell.Label = label; }

            __Children.Add(cell);

            return cell;
        }

        /// <summary>
        /// Returns a tree of grids linked to from (and including) the current grid
        /// </summary>
        /// <param name="maxDepth">How many levels deep to look for the links</param>
        /// <param name="ids">Grid ids already searched</param>
        /// <returns>A tree of grids</returns>
        public GridTreeNode getGridTree(int maxDepth = 10, HashSet<Guid>? ids = null)
        {
            if (this.ParentGridSet == null) { return new GridTreeNode(this); } // If there's no parent GridSet (shouldn't happen) then we can't follow links
            if (maxDepth == 0) { return new GridTreeNode(this); } // If we've looked deep enough
            if (ids == null) { ids = new HashSet<Guid>(); }

            Guid guid;
            if (this.GridId.HasValue) { guid = this.GridId.Value; } else { guid = Guid.NewGuid(); }
            ids.Add(guid);
            GridTreeNode root = new GridTreeNode(this);

            // TODO - Get ref for each Grid that we link to
            List<XmlNodeTag.Command> links = (from Command c in this.ChildrenOfType<XmlNodeTag.Command>(-1) where (c.ID == "Jump.To") select c).ToList();
            foreach (XmlNodeTag.Command link in links)
            {
                string linkTarget = (from Parameter p in link.ChildrenOfType<Parameter>(-1) where p.Key == "grid" select p.Value).FirstOrDefault();
                Grid subGrid = (from Grid g in this.ParentGridSet.Grids where g.Name == linkTarget select g).FirstOrDefault();
                if ((subGrid != null) && (!ids.Contains(subGrid.GridId.GetValueOrDefault())))
                {
                    root.AttachChild(subGrid.getGridTree(maxDepth - 1, ids));
                }
            }

            return root;
        }

        /// <summary>
        /// Splits the specified grid and any linked grids into a new <see cref="GridSet"/>
        /// </summary>
        /// <param name="GridSetName">The name of the new <see cref="GridSet"/></param>
        /// <param name="UpdateHomeLinks">Whether to update Home buttons to point them back to the originating GridSet</param>
        /// <param name="Copy">Whether to copy the grid(s) across instead of moving</param>
        /// <returns>The new GridSet</returns>
        public GridSet moveToNewGridSet(string GridSetName, bool UpdateHomeLinks = true, bool Copy = false)
        {
            // TODO MEDIUM PRIORITY - make use of Copy parameter
            GridTreeNode allPages = getGridTree();
            GridSet newGridSet = new GridSet();

            GridSet? originalGridSet = this.ParentGridSet;

            newGridSet.Name = GridSetName;

            HashSet<string> needingRedirection = new HashSet<string>();

            // Process current grid and make it the home grid
            newGridSet.Children.Add(this);
            newGridSet.Homepage = this;

            // remove from old GridSet
            if (originalGridSet != null)
            {
                originalGridSet.removeGrid(this);
                if (this.Name != null)
                {
                    // Add to list of grids needing redirection
                    needingRedirection.Add(this.Name);
                }
                // If we're redirecting home links, do so now
                if (UpdateHomeLinks)
                {
                    List<Command> homeLinks = (from Command cmd in this.ChildrenOfType<Command>(-1) where (cmd.ID == "Jump.Home") select cmd).ToList();
                    foreach (Command cmd in homeLinks)
                    {
                        cmd.ID = "Settings.ChangeGridSet";
                        cmd.AddChildFromXml("<Parameter Key='gridsetname'>" + originalGridSet.Name + "</Parameter>", 0);
                    }
                }
            }

            foreach (GridTreeNode gridTreeNode in allPages.SelectDescendants())
            {
                if (gridTreeNode.GridItem == null) { continue; }

                // Add grid to new GridSet
                newGridSet.Children.Add(gridTreeNode.GridItem);

                // Remove from old GridSet
                if (originalGridSet != null)
                {
                    originalGridSet.removeGrid(gridTreeNode.GridItem);
                    if (gridTreeNode.GridItem.Name != null)
                    {
                        // Add the grid to a list of those needing redirection
                        needingRedirection.Add(gridTreeNode.GridItem.Name);
                    }
                    // If we're redirecting home links, do so now
                    if (UpdateHomeLinks)
                    {
                        List<Command> homeLinks = (from Command cmd in this.ChildrenOfType<Command>(-1) where (cmd.ID == "Jump.Home") select cmd).ToList();
                        foreach (Command cmd in homeLinks)
                        {
                            cmd.ID = "Settings.ChangeGridSet";
                            cmd.AddChildFromXml("<Parameter Key='gridsetname'>" + originalGridSet.Name + "</Parameter>", 0);
                        }
                    }
                }
            }

            // Find all references to the old grids and change them to point to the new GridSet
            // Need to do it here so that we don't redirect links from moved grids
            foreach (Command cmd in (from Command cmd in originalGridSet.ChildrenOfType<Command>(-1)
                                     where (cmd.ID == "Jump.To"
                                     && (
                                          from Parameter p in cmd.ChildrenOfType<Parameter>(-1)
                                          where (
                                          needingRedirection.Contains(p.Value)
                                          && (p.Key == "grid")
                                          )
                                          select p
                                      ).Count() > 0
                                     )
                                     select cmd))
            {
                cmd.ID = "Settings.ChangeGridSet";
                foreach (Parameter p in cmd.ChildrenOfType<Parameter>(-1))
                {
                    if (p.Key == "grid") { p.Key = "gridsetname"; p.Value = GridSetName; }
                }
            }

            return newGridSet;
        }
    }
}
