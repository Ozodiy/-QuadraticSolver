using Xunit;

public class SolverTests
{
    [Fact]
    public void NoRealRoots()
    {
        string result = Solver.Solve(1, 0, 1);
        Assert.Equal("No real roots.", result);
    }

    [Fact]
    public void OneRealRoot()
    {
        string result = Solver.Solve(1, 2, 1);
        Assert.Contains("One root", result);
    }

    [Fact]
    public void TwoRealRoots()
    {
        string result = Solver.Solve(1, -3, 2);
        Assert.Contains("Two roots", result);
    }

    [Fact]
    public void NotQuadratic()
    {
        string result = Solver.Solve(0, 5, 1);
        Assert.Equal("Not a quadratic equation.", result);
    }
}
