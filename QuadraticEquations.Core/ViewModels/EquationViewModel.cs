using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class EquationViewModel : MvxViewModel
    {
        private readonly IEquationService _equationService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _equationCommand;

        public EquationViewModel(IEquationService equationService)
        {
            _equationService = equationService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }
        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }
        public ICommand EquationCommand
        {
            get
            {
                _equationCommand = _equationCommand ?? new MvxCommand(Equation);
                return _equationCommand;
            }
        }

        private void Equation()
        {
            X1 = _equationService.GetX1(A, B, C);
            X2 = _equationService.GetX2(A, B, C);
        }
    }
}
