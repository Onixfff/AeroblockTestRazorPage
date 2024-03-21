using Aeroblock.DataAccess.Rail.Models;

namespace Aeroblock.DataAccess.Rail.Interface
{
    internal interface IMoveSilo
    {
        public Task<List<SiloBalanceEntity>> GetAsync();
    }
}
