using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public ComposedMission(string name)
        {
            Name = name;
        }

        public event EventHandler<double> OnCalculate;
        
        private List<Func<double,double>> functions = new List<Func<double, double>>();
        public string Name { get; }
        public string Type { get; }
        
        
        public double Calculate(double value)
        {
            foreach (var func in functions)
            {
                value = func(value);
            }
            return value;
        }

        public ComposedMission Add(Func<double,double> func)
        {
            functions.Add(func);
            return this;
        }
    }
}
