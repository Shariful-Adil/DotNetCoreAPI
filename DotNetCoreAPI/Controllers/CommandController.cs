using DotNetCoreAPI.DTO;
using DotNetCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreAPI.Controllers
{
    [Route("api/cmd")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommand _command;

        public CommandController(ICommand command)
        {
            _command = command;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CommandController>/5
       //HttpGet("{id}")]
        [Route("Get")]
        public ActionResult <Command> Get(int id)
        {
        var command = _command.GetCommandById(id);
            if (command == null)
            {
                return NoContent();
            }
            return command;
        }

        // POST api/<CommandController>
        [HttpPost]
        [Route("Create")]
        public bool Create(Command cmd)
        {
           return _command.Create(cmd);
        }

        // PUT api/<CommandController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
