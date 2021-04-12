using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ICliqueFilter
    {
        bool Filter(Clique i_GivenClique);
    }
}
