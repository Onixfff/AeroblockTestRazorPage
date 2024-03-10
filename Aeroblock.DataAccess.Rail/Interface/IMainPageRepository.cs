using Aeroblock.DataAccess.Rail.Models;

namespace Aeroblock.DataAccess.Rail.Interface
{
    public interface IMainPageRepository
    {
        Task<List<VagonVihodEntity>> GetAsync();
    }
}
