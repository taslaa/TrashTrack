using TrashTrack.Api.Controllers;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack_Api.Controllers
{
    public class SchedulesController : BaseCrudController<ScheduleDto, ScheduleUpsertDto, BaseSearchObject, ISchedulesService>
    {
        public SchedulesController(ISchedulesService service, ILogger<BaseController> logger) : base(service, logger)
        {
        }
    }
}
