using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IVehicleModelsService : IBaseService<int, VehicleModelDto, VehicleModelUpsertDto, BaseSearchObject>
    {

    }
}




