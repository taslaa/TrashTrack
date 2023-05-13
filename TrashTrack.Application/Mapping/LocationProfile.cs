using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class LocationProfile : BaseProfile
    {
        public LocationProfile()
        {
            CreateMap<LocationDto, Location>().ReverseMap();

            CreateMap<LocationUpsertDto, Location>();
        }
    }
}
