using domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.ApplicationStore;
using Persistence.ApplicationStore.InMemoryCache;
using Persistence.ApplicationStore.Interfaces;
using Persistence.ApplicationStore.SQLite;
using Persistence.ApplicationStore.SQLServer;

namespace Persistence.F1Team
{
    public class F1TeamRepository : IF1TeamRepository
    {
        IDatabaseHandler databaseHandler;
       
        private readonly F1TeamDbContextSQLServer _SqlDbContext;
        public F1TeamRepository(F1TeamDbContextSQLServer sqlDbContext)
        {
          
            _SqlDbContext = sqlDbContext;
        }

        public Task<Guid> Register(Domain.Entities.F1Team f1Team, string? Type)
        {
    
            databaseHandler = GetDatabaseHandler(Type);
            return databaseHandler.AddF1Team(f1Team);

        }

        public Task<Domain.Entities.F1Team> GetById(Guid id, string? Type)
        {
            databaseHandler = GetDatabaseHandler(Type);
            return databaseHandler.GetF1Team(id);
        }
        private IDatabaseHandler GetDatabaseHandler(string? type)
        {
            if (Enum.TryParse(type, true, out StoreType storeType))
            {
                return storeType switch
                {
                    StoreType.Cache => CheckHandlerExistanceAndHandlerType(typeof(CacheHandler)) ? databaseHandler : new CacheHandler(),
                    StoreType.SQlite => CheckHandlerExistanceAndHandlerType(typeof(SQLiteHandler)) ? databaseHandler : new SQLiteHandler(),
                    StoreType.Sql => CheckHandlerExistanceAndHandlerType(typeof(SQLHandler)) ? databaseHandler : new SQLHandler(_SqlDbContext),
                    _ => CheckHandlerExistanceAndHandlerType(typeof(CacheHandler)) ? databaseHandler : new CacheHandler()
                };
            }
            else
            {
                throw new ArgumentException($"Invalid store type: {type}", nameof(type));
            }
        }

        private bool CheckHandlerExistanceAndHandlerType(Type dbHandlerType)
        {
            return databaseHandler != null && databaseHandler.GetType().Name == dbHandlerType.Name;
        }
    }

}
