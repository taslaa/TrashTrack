using AutoMapper;
using FluentValidation;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class LocationsService : BaseService<Location, LocationDto, LocationUpsertDto, BaseSearchObject, LocationsRepository>, ILocationsService
    {
        public LocationsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<LocationUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
