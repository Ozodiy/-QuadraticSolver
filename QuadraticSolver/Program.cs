using System;
using QuadraticSolverLib;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients a, b, and c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        var result = QuadraticSolver.Solve(a, b, c);

        if (result.numRoots == 0)
            Console.WriteLine("No real roots.");
        else if (result.numRoots == 1)
            Console.WriteLine($"One real root: x = {result.x1}");
        else
            Console.WriteLine($"Two real roots: x1 = {result.x1}, x2 = {result.x2}");
    }
}
