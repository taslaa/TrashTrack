using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class VehicleModelsRepository : BaseRepository<VehicleModel, int, BaseSearchObject>, IVehicleModelsRepository
    {
        public VehicleModelsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}