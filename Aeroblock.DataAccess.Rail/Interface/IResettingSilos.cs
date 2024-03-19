using Aeroblock.DataAccess.Rail.Models;

namespace Aeroblock.DataAccess.Rail.Interface
{
    public interface IResettingSilos
    {
        Task<List<ZeroingSilosEntity>> GetDataAsync();
    }
}
