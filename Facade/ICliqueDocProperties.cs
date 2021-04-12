using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface ICliqueDocProperties
    {
        FacadeExportResults Client { get; set; }
        Clique CurrentCliqueToExport { get; set; }
        ICollection<Clique> CurrentCliquesToExport { get; set; }
        string CurrentPath { get; set; }
        eSaveOptions ESaveOptions { get; set; }
    }
}
