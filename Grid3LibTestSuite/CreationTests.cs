using Grid3lib;
using Grid3lib.XmlNodeTag;

namespace Grid3LibTestSuite
{

    public class CreationTests
    {


        [Theory]
        [InlineData(8, 7, 0, 0, 1, 1, 2, 2, 1, 1, false)]
        [InlineData(8, 7, 0, 0, 2, 2, 1, 2, 2, 2, false)]
        [InlineData(8, 7, 0, 0, 2, 2, 1, 1, 2, 2, true)]
        public void CellOverlapTest(int columns, int rows, int x1, int y1, int colspan1, int rowspan1, int x2, int y2, int colspan2, int rowspan2, bool expectedOverlap)
        {
            // Set up grid
            Grid g = new Grid();
            for (int c = 0; c < columns; c++) { g.AddChildFromXml("<ColumnDefinition />", 0); }
            for (int r = 0; r < rows; r++) { g.AddChildFromXml("<RowDefinition />", 0); }

            // Create cells by adding to grid
            Cell c1; Cell c2; bool isOverlap;
            c1 = g.AddCell(x1, y1, colspan1, rowspan1, "Cell 1");
            try
            {
                c2 = g.AddCell(x2, y2, colspan2, rowspan2, "Cell 2");
                isOverlap = false;
            }
            catch (CellOverlapException)
            {
                isOverlap = true;
            }

            // Check for overlap
            Assert.Equal(expectedOverlap, isOverlap);
        }

        [Theory]
        [InlineData("BasicCreateTest", "MainPage", "SubPage")]
        public void BasicObjectCreate(string gridSetName, string gridNameMain, string gridNameSub)
        {
            // Create gridset
            GridSet gridSet = new GridSet(gridSetName);

            // Create grids
            Grid gridMain = new Grid(true);
            gridMain.Name = gridNameMain;
            Grid gridSub = new Grid(true);
            gridMain.Name = gridNameMain;
            gridSub.Name = gridNameSub;

            // Create cells
            // TODO - create cells, including link from main to sub

            // Add grids to gridset
            gridSet.Grids.Add(gridMain);
            gridSet.Grids.Add(gridSub);
        }

        // public void BasicXmlCreate(string gridName, string Xml)
    }
}
