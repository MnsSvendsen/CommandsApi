using CommandsApi.Moddels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsApi.Repo
{
    interface ICommandsRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
        
    }
}
