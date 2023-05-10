namespace TrashTrack.Core
{
    public class PhotoUpsertDto : BaseUpsertDto
    {
        public byte[] Data { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public int? GarbageId { get; set; }
    }
}
