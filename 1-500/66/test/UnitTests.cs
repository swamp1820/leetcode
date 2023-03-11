namespace test;

public class UnitTests
{
        [Theory]
        [InlineData(new []{4,3,2,1},new []{4,3,2,2})]
        [InlineData(new []{1,2,3},new []{1,2,4})]
        [InlineData(new []{9},new []{1,0})]
        public void Initial_Tests(int[] input, int[] expected)
        {
            var solution = new Solution();
            var result = solution.PlusOne(input);
            Assert.Equal(expected, result);
        }
}