﻿using TrashTrack.Core;

namespace TrashTrack.Infrastructure.Interfaces
{
    public interface IUsersRepository : IBaseRepository<User, int, BaseSearchObject>
    {
    }
}

