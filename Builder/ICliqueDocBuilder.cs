using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Builder
{
    public interface ICliqueDocBuilder
    {
        void CreateDoc(ICollection<Clique> i_CliqueCollection, string i_FilePath);
        void CreateDoc(Clique i_Clique, string i_FilePath);
   
    }
}
