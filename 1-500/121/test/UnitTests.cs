namespace test;

public class UnitTests
{
        [Theory]
        [InlineData(new []{7,1,5,3,6,4},5)]
        [InlineData(new []{7,6,4,3,1},0)]
        [InlineData(new []{1,2,4,2,5,7,2,4,9,0},8)]
        [InlineData(new []{1,2},1)]
        public void Initial_Tests(int[] input, int expected)
        {
            var solution = new Solution();
            var result = solution.MaxProfit(input);
            Assert.Equal(expected,result );
        }
}