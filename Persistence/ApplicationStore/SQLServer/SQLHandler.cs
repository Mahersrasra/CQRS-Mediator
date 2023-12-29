using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.ApplicationStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.ApplicationStore.SQLServer
{
    internal class SQLHandler : IDatabaseHandler
    {
        private readonly F1TeamDbContextSQLServer _context;

        public SQLHandler(F1TeamDbContextSQLServer f1TeamDbContextSQLServer) 
        
        {
            _context= f1TeamDbContextSQLServer;
        }
        public  Task<Guid> AddF1Team(Domain.Entities.F1Team f1Team)
        {
            _context.f1Teams.Add(f1Team);
            _context.SaveChanges();
            return Task.FromResult(f1Team.Id);
        }

        public Task<Domain.Entities.F1Team> GetF1Team(Guid Teamid)
        {
            var team=_context.Set<Domain.Entities.F1Team>().FirstOrDefaultAsync(Team=>Team.Id==Teamid);
            return Task.FromResult(team.Result);
        }
    }
}
