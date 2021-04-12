using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CliqueDocument
    {
        public ICliqueDocCommand Command { get; set; }
        public void Selected()
        {
            Command.Execute();
        }
    }
}
