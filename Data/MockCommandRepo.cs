using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommandRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                
                new Command{ Id=0,
                                HowTo = "Make Omelete", 
                                Line = " With Knife", 
                                Platform = "Kitchen"},
                
                new Command{ Id=1,
                                HowTo = "Make Fried Rice", 
                                Line = " With Rice", 
                                Platform = "Mess"},
                
                new Command{ Id=2,
                                HowTo = "Make Tea", 
                                Line = " With Sugar", 
                                Platform = "Sham Sundar"}

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ Id=0,
                                HowTo = "Make Omelete", 
                                Line = " With Knife", 
                                Platform = "Kitchen"};

        }
    }
}