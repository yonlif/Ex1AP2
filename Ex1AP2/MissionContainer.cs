using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        Dictionary<string, Func<double, double>> string2Function = new Dictionary<string, Func<double, double>>();

        public Func<double, double> this[string key]
        {
            get => string2Function[key];
            set => string2Function[key] = value;
        }
        
        

    }
}
