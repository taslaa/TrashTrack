using TrashTrack.Core;

namespace TrashTrack.Infrastructure.Interfaces
{
    public interface IGarbagesRepository : IBaseRepository<Garbage, int, BaseSearchObject>
    {
    }
}
