namespace Algorithms.Test;

public class FizzBuzzTests
{
    private static readonly List<(int Divisor, string Name)> Names =
    [
        (3, "Ben"),
        (5, "Jeffrey"),
        (7, "Bob"),
    ];
    
    [Fact]
    public void SnapshotTestUpTo5()
    {
        List<string> output = [..FizzBuzz.Generate(Names, 5)];
        List<string> expected = ["1", "2", "Ben", "4", "Jeffrey"];
        Assert.Equal(expected, output);
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Ben")]
    [InlineData(5, "Jeffrey")]
    [InlineData(7, "Bob")]
    [InlineData(15, "BenJeffrey")]
    [InlineData(16, "16")]
    [InlineData(21, "BenBob")]
    [InlineData(35, "JeffreyBob")]
    [InlineData(105, "BenJeffreyBob")]
    public void ShouldPrintExpectedDivisors(int sequence, string expectedOutput)
    {
        List<string> output = [..FizzBuzz.Generate(Names, sequence)];
        Assert.Equal(expectedOutput, output[sequence-1]);
    }
}