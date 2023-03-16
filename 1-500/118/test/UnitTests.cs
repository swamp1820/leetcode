namespace test;

public class UnitTests
{
        [Fact]
        public void Initial_Tests()
        {
            var solution = new Solution();
            var result = solution.Generate(5);
            var expected = new List<List<int>>(){
                new List<int>(){1},
                new List<int>(){1,1},
                new List<int>(){1,2,1},
                new List<int>(){1,3,3,1},
                new List<int>(){1,4,6,4,1}
            };
            Assert.Equal(result, expected);
        }
}