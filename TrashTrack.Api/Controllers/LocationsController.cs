using TrashTrack.Api.Controllers;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack_Api.Controllers
{
    public class LocationsController : BaseCrudController<LocationDto, LocationUpsertDto, BaseSearchObject, ILocationsService>
    {
        public LocationsController(ILocationsService service, ILogger<BaseController> logger) : base(service, logger)
        {
        }
    }
}
