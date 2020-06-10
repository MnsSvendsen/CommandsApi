using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsApi.Moddels;
using CommandsApi.Repo;
using Microsoft.AspNetCore.Mvc;

namespace CommandsApi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : Controller
    {
        private readonly MockCommandsApi _repo = new MockCommandsApi();
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repo.GetAppCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Command>> GetCommandById(int Id)
        {
            var commandItem = _repo.GetCommandById(Id);
            return Ok(commandItem);
        }

    }
}
