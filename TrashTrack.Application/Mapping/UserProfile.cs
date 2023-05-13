using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class UserProfile : BaseProfile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<UserUpsertDto, User>();
        }
    }
}

