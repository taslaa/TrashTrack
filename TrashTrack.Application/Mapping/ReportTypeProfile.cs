using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class ReportTypeProfile : BaseProfile
    {
        public ReportTypeProfile()
        {
            CreateMap<ReportTypeDto, ReportType>().ReverseMap();

            CreateMap<ReportTypeUpsertDto, ReportType>();
        }
    }
}

