﻿using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Grid within a <see cref="Gridset"/>
    /// </summary>
    public class Grid : XmlNodeBasic
    {
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

        public String Name { get; set; }

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
    }
}
