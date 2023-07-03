using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

using TrashTrack.Core;
using TrashTrack.Application.Interfaces;

namespace TrashTrack.Application
{
    public static class Registry
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICitiesService, CitiesService>();
            services.AddScoped<ICountriesService, CountriesService>();
            services.AddScoped<IFeedbacksService, FeedbacksService>();
            services.AddScoped<IGarbagesService, GarbagesService>();
            services.AddScoped<IPhotosService, PhotosService>();
            services.AddScoped<ILocationsService, LocationsService>();
            services.AddScoped<INotificationsService, NotificationsService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRewardsService, RewardsService>();
            services.AddScoped<ISchedulesService, SchedulesService>();
            services.AddScoped<IUserVehiclesService, UserVehiclesService>();
            services.AddScoped<IUserRewardsService, UserRewardsService>();
            services.AddScoped<IVehicleModelsService, VehicleModelsService>();
            services.AddScoped<IReportsService, ReportsService>();
            services.AddScoped<IReportTypesService, ReportTypesService>();
            services.AddScoped<IVehiclesService, VehiclesService>();
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CityUpsertDto>, CityValidator>();
            services.AddScoped<IValidator<CountryUpsertDto>, CountryValidator>();
            services.AddScoped<IValidator<FeedbackUpsertDto>, FeedbackValidator>();
            services.AddScoped<IValidator<GarbageUpsertDto>, GarbageValidator>();
            services.AddScoped<IValidator<PhotoUpsertDto>, PhotoValidator>();
            services.AddScoped<IValidator<LocationUpsertDto>, LocationValidator>();
            services.AddScoped<IValidator<NotificationUpsertDto>, NotificationValidator>();
            services.AddScoped<IValidator<UserUpsertDto>, UserValidator>();
            services.AddScoped<IValidator<RewardUpsertDto>, RewardValidator>();
            services.AddScoped<IValidator<ScheduleUpsertDto>, ScheduleValidator>();
            services.AddScoped<IValidator<UserVehicleUpsertDto>, UserVehicleValidator>();
            services.AddScoped<IValidator<VehicleModelUpsertDto>, VehicleModelValidator>();
            services.AddScoped<IValidator<ReportTypeUpsertDto>, ReportTypeValidator>();
            services.AddScoped<IValidator<ReportUpsertDto>, ReportValidator>();
            services.AddScoped<IValidator<UserRewardUpsertDto>, UserRewardValidator>();
            services.AddScoped<IValidator<VehicleUpsertDto>, VehicleValidator>();
            services.AddScoped<IValidator<UserChangePasswordDto>, UserPasswordValidator>();

            // TODO: Add other validators
        }
    }
}
