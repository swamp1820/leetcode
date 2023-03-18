namespace test;

public class UnitTests
{
        [Theory]
        [InlineData("a","b", false)]
        [InlineData("aa","ab", false)]
        [InlineData("aa","aab", true)]
        public void Initial_Tests(string input, string input2,bool expected)
        {
            var solution = new Solution();
            var result = solution.CanConstruct(input, input2);
            Assert.Equal(expected,result);
        }
}