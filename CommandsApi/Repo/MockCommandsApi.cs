using CommandsApi.Moddels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CommandsApi.Repo
{
    public class MockCommandsApi : ICommandsRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "HowTo0", Line = "Line0", Platform = "Platform0" },
                new Command { Id = 1, HowTo = "HowTo1", Line = "Line1", Platform = "Platform1" },
                new Command { Id = 2, HowTo = "HowTo2", Line = "Line2", Platform = "Platform2" }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "HowTo", Line = "Line", Platform = "Platform" };
        }
    }
}
