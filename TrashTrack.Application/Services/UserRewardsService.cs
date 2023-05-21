using AutoMapper;
using FluentValidation;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class UserRewardsService : BaseService<UserReward, UserRewardDto, UserRewardUpsertDto, BaseSearchObject, UserRewardsRepository>, IUserRewardsService
    {
        public UserRewardsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserRewardUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
