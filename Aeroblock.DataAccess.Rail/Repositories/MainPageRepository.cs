using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroblock.DataAccess.Rail.Repositories
{
    public class MainPageRepository : IMainPageRepository
    {
        private readonly RailDbContext _dbContext;

        public MainPageRepository(RailDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<VagonVihodEntity>> GetAsync()
        {
            return await _dbContext.VagonVihods.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        }
    }
}
