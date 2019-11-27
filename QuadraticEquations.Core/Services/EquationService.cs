using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class EquationService : IEquationService
    {
        public double GetX1(double a, double b, double c)
        {
            return (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

        public double GetX2(double a, double b, double c)
        {
            return (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
}
