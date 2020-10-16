using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    interface ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);

        
    }
}