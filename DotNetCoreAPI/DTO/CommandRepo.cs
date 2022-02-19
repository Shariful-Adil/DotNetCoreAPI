using DotNetCoreAPI.DatabaseContext;
using DotNetCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI.DTO
{
    public class CommandRepo : ICommand
    {
        private readonly CommanderContext _context;

        public CommandRepo(CommanderContext context) {
            _context = context;
        }

        public bool Create(Command cmd)
        {
            _context.Commands.Add(cmd);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Command cmd)
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
           return _context.Commands.FirstOrDefault(p=>p.ID==id);
        }

        public IEnumerable<Command> GetCommantds()
        {
            return _context.Commands.ToList();
        }

        public bool Update(Command cmd)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
