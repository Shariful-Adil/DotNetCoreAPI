using DotNetCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI.DTO
{
     public interface ICommand
    {
        IEnumerable<Command> GetCommantds();
        Command GetCommandById(int id);

        public bool Create(Command cmd);

        public bool Update(Command cmd);

        public bool Delete(Command cmd);
    }
}
