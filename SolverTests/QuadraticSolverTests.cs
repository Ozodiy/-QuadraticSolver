using Xunit;
using SolverLib;

namespace SolverTests
{
    public class QuadraticSolverTests
    {
        [Fact]
        public void NoRealRoots()
        {
            var result = QuadraticSolver.Solve(1, 0, 1);
            Assert.Equal(0, result.rootCount);
            Assert.Null(result.root1);
            Assert.Null(result.root2);
        }

        [Fact]
        public void OneRealRoot()
        {
            var result = QuadraticSolver.Solve(1, 2, 1);
            Assert.Equal(1, result.rootCount);
            Assert.Equal(-1, result.root1);
            Assert.Null(result.root2);
        }

        [Theory]
        [InlineData(1, -3, 2, 2, 1)]
        [InlineData(1, 5, 6, -2, -3)]
        public void TwoRealRoots(double a, double b, double c, double expected1, double expected2)
        {
            var result = QuadraticSolver.Solve(a, b, c);
            Assert.Equal(2, result.rootCount);
            Assert.Contains(result.root1.Value, new[] { expected1, expected2 });
            Assert.Contains(result.root2.Value, new[] { expected1, expected2 });
        }
    }
}
