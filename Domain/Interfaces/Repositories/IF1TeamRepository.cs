using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interfaces.Repositories
{
    public interface IF1TeamRepository
    {
        Task<F1Team> GetById(Guid id,string? Type);
        Task<Guid> Register(F1Team f1Team, string? Type);
    }
}
