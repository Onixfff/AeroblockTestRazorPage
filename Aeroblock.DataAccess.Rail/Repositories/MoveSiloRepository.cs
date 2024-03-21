using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeroblock.DataAccess.Rail.Repositories
{
    public class MoveSiloRepository(RailDbContext dbContext) : IMoveSilo
    {
        private readonly RailDbContext _dbContext = dbContext;

        public async Task<List<MoveSiloEntity>> GetAsync()
        {
            return await _dbContext.MoveSilos
                .AsNoTracking()
                .Include(x => x.TargetMoveSilo)
                .Include(x => x.SourceMoveSilo)
                .OrderByDescending(x => x.Timestamp)
                .ToListAsync();
        }
    }
}
