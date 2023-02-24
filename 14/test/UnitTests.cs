namespace test;

public class UnitTest1
{
        [Theory]
        [InlineData(new []{"dog","racecar","car"},"")]
        [InlineData(new []{"flower","flow","flight"},"fl")]
        [InlineData(new []{"reflower","flow","flight"},"")]
        public void Initial_Tests(string[] input, string expected)
        {
            var solution = new Solution();
            var result = solution.LongestCommonPrefix(input);
            Assert.Equal(result, expected);
        }
}