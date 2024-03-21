using Aeroblock.DataAccess.Rail.Models;

namespace Aeroblock.DataAccess.Rail.Interface
{
    public interface IMoveSilo
    {
        public Task<List<MoveSiloEntity>> GetAsync();
    }
}
