using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class LocationsRepository : BaseRepository<Location, int, BaseSearchObject>, ILocationsRepository
    {
        public LocationsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}