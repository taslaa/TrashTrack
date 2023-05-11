using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class VehiclesRepository : BaseRepository<Vehicle, int, BaseSearchObject>, IVehiclesRepository
    {
        public VehiclesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}