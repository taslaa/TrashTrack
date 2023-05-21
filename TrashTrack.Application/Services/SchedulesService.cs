using AutoMapper;
using FluentValidation;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class SchedulesService : BaseService<Schedule, ScheduleDto, ScheduleUpsertDto, BaseSearchObject, SchedulesRepository>, ISchedulesService
    {
        public SchedulesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ScheduleUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
