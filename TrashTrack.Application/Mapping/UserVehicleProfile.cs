using TrashTrack.Core;

namespace TrashTrack.Application
{
    public class UserVehicleProfile : BaseProfile
    {
        public UserVehicleProfile()
        {
            CreateMap<UserVehicleDto, UserVehicle>().ReverseMap();

            CreateMap<UserVehicleUpsertDto, UserVehicle>();
        }
    }
}

