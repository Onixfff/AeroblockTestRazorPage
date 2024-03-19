using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeroblock.DataAccess.Rail.Repositories
{
    public class ResettingSilos : IResettingSilos
    {
        private readonly RailDbContext _context;

        public ResettingSilos(RailDbContext railDbContext)
        {
            _context = railDbContext;
        }

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
