namespace Grid3LibTestSuite
{
    public class BasicTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        /*[Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }*/

        int Add(int one, int two)
        {
            return one + two;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        /*[InlineData(6)]*/
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}