using AutoMapper;
using FluentValidation;
using TrashTrack.Application.Interfaces;
using TrashTrack.Core;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class GarbagesService : BaseService<Garbage, GarbageDto, GarbageUpsertDto, BaseSearchObject, GarbagesRepository>, IGarbagesService
    {
        public GarbagesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<GarbageUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
