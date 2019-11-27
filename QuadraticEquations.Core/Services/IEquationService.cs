using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IEquationService
    {
        double GetX1(double a, double b, double c);

        double GetX2(double a, double b, double c);
    }
}
