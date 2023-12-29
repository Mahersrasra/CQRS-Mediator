using Persistence.ApplicationStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.ApplicationStore.SQLite
{
    internal class SQLiteHandler : IDatabaseHandler
    {
        public SQLiteHandler() { }
        public Task<Guid> AddF1Team(Domain.Entities.F1Team f1Team)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.F1Team> GetF1Team(Guid Teamid)
        {
            throw new NotImplementedException();
        }
    }
}
