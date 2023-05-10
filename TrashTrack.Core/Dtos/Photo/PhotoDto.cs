namespace TrashTrack.Core
{
    public class PhotoDto : BaseDto
    {
        public byte[] Data { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public int? GarbageId { get; set; }
        public GarbageDto? Garbage { get; set; }
    }
}
