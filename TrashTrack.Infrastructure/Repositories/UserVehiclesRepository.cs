using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class UserVehiclesRepository : BaseRepository<UserVehicle, int, BaseSearchObject>, IUserVehiclesRepository
    {
        public UserVehiclesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}