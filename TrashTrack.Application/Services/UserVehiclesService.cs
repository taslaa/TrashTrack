using AutoMapper;
using FluentValidation;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class UserVehiclesService : BaseService<UserVehicle, UserVehicleDto, UserVehicleUpsertDto, BaseSearchObject, UserVehiclesRepository>, IUserVehiclesService
    {
        public UserVehiclesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserVehicleUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
