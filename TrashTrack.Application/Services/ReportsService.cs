using AutoMapper;
using FluentValidation;

using TrashTrack.Core;
using TrashTrack.Application.Interfaces;
using TrashTrack.Infrastructure;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application
{
    public class ReportsService : BaseService<Report, ReportDto, ReportUpsertDto, BaseSearchObject, IReportsRepository>, IReportsService
    {
        public ReportsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReportUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
