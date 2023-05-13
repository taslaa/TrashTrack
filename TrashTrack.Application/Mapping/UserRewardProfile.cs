using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class UserRewardProfile : BaseProfile
    {
        public UserRewardProfile()
        {
            CreateMap<UserRewardDto, UserReward>().ReverseMap();

            CreateMap<UserRewardUpsertDto, UserReward>();
        }
    }
}

