using Xunit;
using QuadraticSolverLib;

public class QuadraticSolverTests
{
    [Theory]
    [InlineData(1, 0, 1)]
    [InlineData(1, 2, 5)]
    public void NoRealRoots(double a, double b, double c)
    {
        var result = QuadraticSolver.Solve(a, b, c);
        Assert.Equal(0, result.numRoots);
        Assert.Null(result.x1);
        Assert.Null(result.x2);
    }

    [Theory]
    [InlineData(1, 2, 1, -1)]
    [InlineData(4, 4, 1, -0.5)]
    public void OneRealRoot(double a, double b, double c, double expectedX)
    {
        var result = QuadraticSolver.Solve(a, b, c);
        Assert.Equal(1, result.numRoots);
        Assert.Equal(expectedX, result.x1, 5);
        Assert.Null(result.x2);
    }

    [Theory]
    [InlineData(1, -3, 2, 2, 1)]
    [InlineData(1, 0, -4, 2, -2)]
    public void TwoRealRoots(double a, double b, double c, double expectedX1, double expectedX2)
    {
        var result = QuadraticSolver.Solve(a, b, c);
        Assert.Equal(2, result.numRoots);
        Assert.Contains(result.x1.Value, new[] { expectedX1, expectedX2 });
        Assert.Contains(result.x2.Value, new[] { expectedX1, expectedX2 });
    }

    [Fact]
    public void ThrowsOnZeroA()
    {
        Assert.Throws<ArgumentException>(() => QuadraticSolver.Solve(0, 2, 1));
    }
}
