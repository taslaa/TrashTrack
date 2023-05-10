using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IGarbagesService : IBaseService<int, GarbageDto, GarbageUpsertDto, BaseSearchObject>
    {

    }
}


