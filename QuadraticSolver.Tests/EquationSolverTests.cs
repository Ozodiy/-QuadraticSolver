using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class EquationSolverTests
    {
        [Theory]
        [InlineData(1, 0, 1)]
        public void NoRealRoots(double a, double b, double c)
        {
            var result = EquationSolver.Solve(a, b, c);
            Assert.Equal(0, result.rootCount);
            Assert.Null(result.root1);
            Assert.Null(result.root2);
        }

        [Theory]
        [InlineData(1, 2, 1, -1)]
        public void OneRealRoot(double a, double b, double c, double expected)
        {
            var result = EquationSolver.Solve(a, b, c);
            Assert.Equal(1, result.rootCount);
            Assert.Equal(expected, result.root1.Value, 5);
            Assert.Null(result.root2);
        }

        [Theory]
        [InlineData(1, -3, 2, 2, 1)]
        [InlineData(1, 5, 6, -2, -3)]
        public void TwoRealRoots(double a, double b, double c, double expected1, double expected2)
        {
            var result = EquationSolver.Solve(a, b, c);
            Assert.Equal(2, result.rootCount);
            Assert.Contains(result.root1.Value, new[] { expected1, expected2 });
            Assert.Contains(result.root2.Value, new[] { expected1, expected2 });
        }

        [Fact]
        public void InvalidCoefficient_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EquationSolver.Solve(0, 2, 1));
        }
    }
}
