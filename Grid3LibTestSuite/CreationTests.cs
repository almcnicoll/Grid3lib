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
        [InlineData(8, 7, 3, 1, 4, 2, 4, 1, 2, 2, true)]
        public void CellOverlapTest(int columns, int rows, int x1, int y1, int colspan1, int rowspan1, int x2, int y2, int colspan2, int rowspan2, bool expectedOverlap)
        {
            // Set up grid
            Grid g = new Grid();
            //for (int c = 0; c < columns; c++) { g.AddChildFromXml("<ColumnDefinition />", 0); }
            //for (int r = 0; r < rows; r++) { g.AddChildFromXml("<RowDefinition />", 0); }
            for (int c = 0; c < columns; c++) { g.AddChildOfType<ColumnDefinition>(true); }
            for (int r = 0; r < rows; r++) { g.AddChildOfType<RowDefinition>(true); }

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
            Cell cellMain1 = gridMain.AddCell(0, 0, 1, 1, "Sub grid");
            Command command1 = new Command(Grid3.Actions.JumpTo, new Dictionary<string, string> { { "grid", gridSub.Name } });
            cellMain1.AddCommand(command1);

            Cell cellSub2 = gridSub.AddCell(0, 0, 1, 1, "Main grid");
            Command command2 = new Command(Grid3.Actions.JumpTo, new Dictionary<string, string> { { "grid", gridMain.Name } });
            cellSub2.AddCommand(command2);

            // Add grids to gridset
            gridSet.Grids.Add(gridMain);
            gridSet.Grids.Add(gridSub);

            // All went OK
            Assert.True(true);
        }

        // TODO - Write OpenSaveCompare test
        public void OpenSaveCompare() { }
    }
}
