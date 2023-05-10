using RideWithMe.Core;

namespace RideWithMe.Common.Services
{
    public class EnumsService : IEnumsService
    {
        public Task<IEnumerable<KeyValuePair<int, string>>> GetVehicleTypesAsync() => Task.FromResult(GetValues<VehicleType>());

        private IEnumerable<KeyValuePair<int, string>> GetValues<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<int>()
                       .Select(e => new KeyValuePair<int, string>(e, Enum.GetName(typeof(T), e)!));
        }
    }
}