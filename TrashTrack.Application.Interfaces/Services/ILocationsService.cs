using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface ILocationsService : IBaseService<int, LocationDto, LocationUpsertDto, BaseSearchObject>
    {

    }
}


