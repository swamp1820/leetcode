namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] {1,3,5,2,7,5}, 1,5,2)]
    [InlineData(new[] {1,1,1,1}, 1,1,10)]
    [InlineData(new[] {1,1,2,1,1}, 1,1,6)]
    [InlineData(new[] {1,1,5}, 1,5,2)]
    [InlineData(new[] {1}, 1,1,1)]
    [InlineData(new[] {1,1,0,1}, 1,1,4)]
    [InlineData(new[] {1,1,1,5}, 1,1,6)]
    [InlineData(new[] {2,1,5,3,4}, 1,5,6)]
    [InlineData(new[] {2,1,5,3}, 1,5,4)]
    [InlineData(new[] {3,2,1,5,3,4,3}, 1,5,12)]
    [InlineData(new[] {2,1,5,3,4,2}, 1,5,8)]
    [InlineData(new[] {2,3,4,1,5,2}, 1,5,8)]
    [InlineData(new[] {2,4,1,1,5,3,4},1,5,12)]
    [InlineData(new[] {1,3,2,2,1,3,2,2},1,3,20)]
     [InlineData(new[] {35054,398719,945315,945315,820417,945315,35054,945315,171832,945315,35054,109750,790964,441974,552913},35054,945315,81)] 
    public void Initial_Tests(int[] input, int min, int max, long expected)
    {
        var solution = new Solution();
        var result = solution.CountSubarrays(input, min, max);
        Assert.Equal(expected, result);
    }
}

//     15
//     153
//    115
//    1153
//     1534
//    11534
//   4115
//   41153
//   411534
//  24115
//  241153
//  2411534
