using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface ICitiesService : IBaseService<int, CityDto, CityUpsertDto, BaseSearchObject>
    {

    }
}

