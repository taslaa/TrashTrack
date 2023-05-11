namespace TrashTrack.Common.Services
{
    public interface IEnumsService
    {
        Task<IEnumerable<KeyValuePair<int, string>>> GetVehicleTypesAsync();
    }
}
