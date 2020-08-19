using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //DESKTOP-25M9DJO\MSSQLSERVER01
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}