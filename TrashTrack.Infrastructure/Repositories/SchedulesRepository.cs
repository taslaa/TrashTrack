using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class SchedulesRepository : BaseRepository<Schedule, int, BaseSearchObject>, ISchedulesRepository
    {
        public SchedulesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}