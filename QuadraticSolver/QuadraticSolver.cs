using System;

namespace QuadraticSolverLib
{
    public class QuadraticSolver
    {
        public static (int numRoots, double? x1, double? x2) Solve(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Coefficient 'a' cannot be zero.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return (0, null, null);
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return (1, x, null);
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                return (2, x1, x2);
            }
        }
    }
}
