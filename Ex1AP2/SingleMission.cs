using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get; }
        public string Type { get; }
        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
