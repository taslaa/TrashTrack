using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Application.Interfaces
{
    public interface IReportsRepository : IBaseService<int, ReportDto, ReportUpsertDto, ReportSearchObject>
    {

    }
}


