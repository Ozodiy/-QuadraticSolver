using System;

public class Solver
{
    public static string Solve(double a, double b, double c)
    {
        double d = b * b - 4 * a * c;

        if (a == 0)
            return "Not a quadratic equation.";
        else if (d < 0)
            return "No real roots.";
        else if (d == 0)
        {
            double x = -b / (2 * a);
            return $"One root: x = {x}";
        }
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return $"Two roots: x1 = {x1}, x2 = {x2}";
        }
    }
}
