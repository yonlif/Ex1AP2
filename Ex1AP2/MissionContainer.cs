using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        private Dictionary<string, Func<double, double>> string2Function = new Dictionary<string, Func<double, double>>();

        public Func<double, double> this[string key]
        {
            get
            {
                if (!string2Function.ContainsKey(key))
                {
                    string2Function[key] = x => x;
                }
                return string2Function[key];
            }
            set => string2Function[key] = value;

        }

        public IEnumerable<string> getAllMissions()
        {
            return new List<string>(string2Function.Keys);
        }
    }
}
