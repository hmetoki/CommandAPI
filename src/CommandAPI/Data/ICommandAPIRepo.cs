using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreatreCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command command);

    }

}