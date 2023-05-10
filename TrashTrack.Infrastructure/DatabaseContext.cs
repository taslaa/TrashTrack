using Microsoft.EntityFrameworkCore;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Photo> Photos { get; set; } = null!;
        public DbSet<Feedback> Feedbacks { get; set; } = null!;
        public DbSet<Garbage> Garbages { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<Reward> Rewards { get; set; } = null!;
        public DbSet<UserVehicle> UserVehicles { get; set; } = null!;
        public DbSet<VehicleModel> VehicleModels { get; set; } = null!;
        public DbSet<Schedule> Schedules { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;
        public DbSet<ReportType> ReportTypes { get; set; } = null!;
        public DbSet<UserReward> UserRewards { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; } = null!;
    }
}
