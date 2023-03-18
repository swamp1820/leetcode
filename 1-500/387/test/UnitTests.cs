namespace test;

public class UnitTests
{
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        public void Initial_Tests(string input, int expected)
        {
            var solution = new Solution();
            var result = solution.FirstUniqChar(input);
            Assert.Equal(expected,result);
        }
}