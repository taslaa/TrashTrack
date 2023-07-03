using TrashTrack.Api.Controllers;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack_Api.Controllers
{
    public class UserVehiclesController : BaseCrudController<UserVehicleDto, UserVehicleUpsertDto, BaseSearchObject, IUserVehiclesService>
    {
        public UserVehiclesController(IUserVehiclesService service, ILogger<BaseController> logger) : base(service, logger)
        {
        }
    }
}
