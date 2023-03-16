namespace test;

public class UnitTests
{
        [Fact]
        public void Initial_Tests()
        {
            var solution = new Solution();
            var result = solution.MatrixReshape(new int[][]{new int[]{1,2},new int[]{3,4}},1,4);
            var expected = new int[][]{new int[]{1,2,3,4}};
            Assert.Equal(result, expected);
        }
}