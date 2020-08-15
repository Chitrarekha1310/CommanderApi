using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //DESKTOP-25M9DJO\MSSQLSERVER01
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}