using Microsoft.Extensions.DependencyInjection;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IPhotosRepository, PhotosRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IReportsRepository, ReportsRepository>();
            services.AddScoped<IReportTypesRepository, ReportTypesRepository>();
            services.AddScoped<IFeedbacksRepository, FeedbacksRepository>();
            services.AddScoped<IGarbagesRepository, GarbagesRepository>();
            services.AddScoped<INotificationsRepository, NotificationsRepository>();
            services.AddScoped<IRewardsRepository, RewardsRepository> ();
            services.AddScoped<ISchedulesRepository, SchedulesRepository> ();
            services.AddScoped<IUserRewardsRepository, UserRewardsRepository> ();
            services.AddScoped<IVehicleModelsRepository, VehicleModelsRepository> ();
            services.AddScoped<IVehiclesRepository, VehiclesRepository> ();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
