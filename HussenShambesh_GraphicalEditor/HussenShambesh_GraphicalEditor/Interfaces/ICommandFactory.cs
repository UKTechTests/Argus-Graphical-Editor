using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HussenShambesh_GraphicalEditor.Interfaces
{
    public interface ICommandFactory
    {
        ICommandExecute GetCommandExecuteHandler(string command);
    }
}
