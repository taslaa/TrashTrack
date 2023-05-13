using AutoMapper;
using FluentValidation;

using TrashTrack.Core;
using TrashTrack.Application.Interfaces;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class VehicleModelsService : BaseService<VehicleModel, VehicleModelDto, VehicleModelUpsertDto, BaseSearchObject, IVehicleModelsRepository>, IVehicleModelsService
    {
        public VehicleModelsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<VehicleModelUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }
    }
}