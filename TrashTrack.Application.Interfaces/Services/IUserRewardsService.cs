﻿using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IUserRewardsService : IBaseService<int, UserRewardDto, UserRewardUpsertDto, BaseSearchObject>
    {

    }
}



