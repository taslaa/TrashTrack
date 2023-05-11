using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class GarbagesRepository : BaseRepository<Garbage, int, BaseSearchObject>, IGarbagesRepository
    {
        public GarbagesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}