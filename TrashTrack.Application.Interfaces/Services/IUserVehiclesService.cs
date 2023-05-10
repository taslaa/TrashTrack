using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IUserVehiclesService : IBaseService<int, UserVehicleDto, UserVehicleUpsertDto, BaseSearchObject>
    {

    }
}



