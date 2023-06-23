namespace Grid3LibTestSuite
{
    public class BasicTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, Add(2, 3));
        }


        int Add(int one, int two)
        {
            return one + two;
        }
    }
}