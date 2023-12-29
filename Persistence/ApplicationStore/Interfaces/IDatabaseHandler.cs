using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.ApplicationStore.Interfaces
{
    public interface IDatabaseHandler
    {
        public  Task<Guid> AddF1Team(Domain.Entities.F1Team f1Team);
        public  Task<Domain.Entities.F1Team> GetF1Team(Guid Teamid);


    }
}
