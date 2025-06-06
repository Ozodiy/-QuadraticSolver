using System;

namespace QuadraticSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation Solver (ax² + bx + c = 0)");
            
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two real roots: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One real root: {root}");
            }
            else
            {
                Console.WriteLine("No real roots (discriminant < 0)");
            }
        }
    }
}