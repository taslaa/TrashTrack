using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class UserRewardsRepository : BaseRepository<UserReward, int, BaseSearchObject>, IUserRewardsRepository
    {
        public UserRewardsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}