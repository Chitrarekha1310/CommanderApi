using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
     //Route api/controller
    [Route("api/commands")]
    
    [ApiController]
    public class CommandsController : ControllerBase
    {
            private readonly ICommanderRepo _repository;
            //dependency injection
            public CommandsController(ICommanderRepo repository)
            {
                _repository = repository;
            }
            [HttpGet]
            public ActionResult <IEnumerable<Command>> GetAllCommands()
            {
                var commands = _repository.GetAllCommands();
                return Ok(commands);
            }

            //defining route as api/command/id
            [HttpGet("{id}")]
            public ActionResult<Command> GetCommandById (int id)
            {
                var commandItem = _repository.GetCommandById(id);
                return Ok(commandItem);
            }
    }
}