using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface ISchedulesService : IBaseService<int, ScheduleDto, ScheduleUpsertDto, BaseSearchObject>
    {

    }
}



