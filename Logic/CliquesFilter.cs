using Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CliquesFilter : ICliqueFilter
    {
        private readonly Func<Clique, bool> r_Filter;
        public CliquesFilter(Func<Clique,bool> i_GivenFunc)
        {
            r_Filter = i_GivenFunc;
        }
        public bool Filter(Clique i_CliqueToFilter)
        {
            return r_Filter.Invoke(i_CliqueToFilter);
        }
    }
}
