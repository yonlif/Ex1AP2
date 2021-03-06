﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public SingleMission(Func<double,double> func, string name)
        {
            this.Name = name;
            this.func = func;
            Type = "Single";
        }

        public event EventHandler<double> OnCalculate;
        
        private Func<double, double> func;
        public string Name { get; }
        public string Type { get; }
        
        public double Calculate(double value)
        {
            double result = func(value);
            if (OnCalculate != null) OnCalculate(this, result);
            return result;
        }
    }
}
