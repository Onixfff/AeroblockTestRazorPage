using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeroblock.DataAccess.Rail.Repositories
{
    public class ResettingSilosRepository(RailDbContext railDbContext) : IResettingSilos
    {
        private readonly RailDbContext _context = railDbContext;

        public async Task<List<ZeroingSilosEntity>> GetDataAsync()
        {
            return await _context.ZeroingSilos
                .AsNoTracking()
                .Include(x => x.SiloBalance)
                .OrderBy(x => x.Date)
                .ToListAsync();
        }
    }
}
