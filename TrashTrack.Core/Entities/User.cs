namespace TrashTrack.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public Role Role { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public Gender Gender { get; set; }
        public string? Biography { get; set; }
        public DateTime BirthDate { get; set; }

        public int? ProfilePhotoId { get; set; }
        public Photo? ProfilePhoto { get; set; }

        public ICollection<Notification>? Notifications { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; } = null!;
        public ICollection<UserReward> UserRewards { get; set; } = null!;
        public ICollection<UserVehicle> UserVehicles { get; set; } = null!;
        public ICollection<Report> MyReports { get; set; } = null!;
        public ICollection<Report> Reports { get; set; } = null!;
    }
}
