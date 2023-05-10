using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IUsersService : IBaseService<int, UserDto, UserUpsertDto, BaseSearchObject>
    {

    }
}



