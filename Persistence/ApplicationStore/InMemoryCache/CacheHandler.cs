using Persistence.ApplicationStore.Interfaces;

namespace Persistence.ApplicationStore.InMemoryCache
{
    public class CacheHandler : IDatabaseHandler
    {
        private readonly Dictionary<Guid, Domain.Entities.F1Team> F1Teams;
        public CacheHandler()
        {
            if (F1Teams == null) { F1Teams = new(); }


        }

        public async Task<Guid> AddF1Team(Domain.Entities.F1Team f1Team)
        {
            F1Teams[f1Team.Id] = f1Team;
            return await Task.FromResult(f1Team.Id);
        }

        public async Task<Domain.Entities.F1Team> GetF1Team(Guid Teamid)
        {
            return await Task.FromResult(F1Teams.GetValueOrDefault(Teamid));
        }
    }
}
