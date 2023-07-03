using TrashTrack.Api.Controllers;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack_Api.Controllers
{
    public class UserRewardsController : BaseCrudController<UserRewardDto, UserRewardUpsertDto, BaseSearchObject, IUserRewardsService>
    {
        public UserRewardsController(IUserRewardsService service, ILogger<BaseController> logger) : base(service, logger)
        {
        }
    }
}
