using TrashTrack.Core;
using TrashTrack.Application.Interfaces;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Api.Controllers
{
    public class VehicleModelsController : BaseCrudController<VehicleModelDto, VehicleModelUpsertDto, BaseSearchObject, IVehicleModelsService>
    {
        public VehicleModelsController(IVehicleModelsService service, ILogger<VehicleModelsController> logger) : base(service, logger)
        {
        }
    }
}
