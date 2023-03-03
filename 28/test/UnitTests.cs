namespace test;

public class UnitTests
{
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto",-1)]
        [InlineData("mississippi", "issipi",-1)]
        [InlineData("a", "a",0)]
        [InlineData("aaa", "a",0)]
         [InlineData("mississippi", "sipp",6)]
        public void Initial_Tests(string input1, string input2, int expected)
        {
            var solution = new Solution();
            var result = solution.StrStr(input1,input2);
            Assert.Equal(expected,result);
        }
}