using AutoMapper;
using FluentValidation;

using TrashTrack.Core;
using TrashTrack.Application.Interfaces;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class ReportTypesService : BaseService<ReportType, ReportTypeDto, ReportTypeUpsertDto, BaseSearchObject, IReportTypesRepository>, IReportTypesService
    {
        public ReportTypesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReportTypeUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
