using TrashTrack.Core;

namespace TrashTrack.Infrastructure.Interfaces
{
    public class ReportSearchObject : BaseSearchObject
    {
        public int? ReportTypeId { get; set; }
        public string? Note { get; set; } = null!;
        public ReportState? ReportState { get; set; }
        public int? ReporterUserId { get; set; }
        public int? ReportedUserId { get; set; }
    }
}