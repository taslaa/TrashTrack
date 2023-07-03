using TrashTrack.Api.Controllers;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack_Api.Controllers
{
    public class GarbagesController : BaseCrudController<GarbageDto, GarbageUpsertDto, BaseSearchObject, IGarbagesService>
    {
        public GarbagesController(IGarbagesService service, ILogger<BaseController> logger) : base(service, logger)
        {
        }
    }
}
